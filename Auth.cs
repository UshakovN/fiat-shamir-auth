using System;
using System.Numerics;
using System.Threading.Tasks;

namespace ZeroKnowledgeProof
{

    public static class Extension
    {
        public static BigInteger NextBigInteger(this Random random, BigInteger min, BigInteger max)
        {
            if (min > max) 
                throw new ArgumentException();

            if (min == max) 
                return min;

            BigInteger bound = max - 1 - min;
            byte[] bytes = bound.ToByteArray();

            byte lastMask = 0b11111111;

            for (byte mask = 0b10000000; mask > 0; mask >>= 1, lastMask >>= 1)
            {
                if ((bytes[bytes.Length - 1] & mask) == mask) 
                    break;
            }

            while (true)
            {
                random.NextBytes(bytes);

                bytes[bytes.Length - 1] &= lastMask;
                var result = new BigInteger(bytes);

                if (result <= bound) 
                    return result + min;
            }
        }

        public static BigInteger BigIntSqrt(BigInteger number)
        {
            var sqrt = Math.Exp(BigInteger.Log(number) / 2);
            return (BigInteger)Math.Floor(sqrt);
        }
    }

    public class Auth
    {
        private static Random random = new Random();

        private static bool HasPrimeNumber(BigInteger number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            BigInteger boundary = Extension.BigIntSqrt(number);

            for (BigInteger i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static BigInteger GeneratePrime(int length = 10)
        {
            if (length == 0)
                return 0;

            BigInteger number = 4;

            Task.Run(() =>
            {
                while (!HasPrimeNumber(number))
                {
                    BigInteger min = BigInteger.Pow(10, length - 1);
                    BigInteger max = BigInteger.Pow(10, length) - 1;

                    number = random.NextBigInteger(min, max);
                }
            }).Wait();

            return number;
        }

        public static BigInteger ChooseS(BigInteger n)
        {
            BigInteger s;

            for (; ; )
            {
                s = random.NextBigInteger(1, n - 1);

                BigInteger gcd = BigInteger.GreatestCommonDivisor(s, n);

                if (gcd == 1)
                    break;
            }
            return s;
        }

        public static BigInteger CalculateV(BigInteger s, BigInteger n)
        {
            BigInteger v = BigInteger.ModPow(s, 2, n);
            return v;
        }

        public static BigInteger ChooseR(BigInteger n)
        {
            BigInteger r = random.NextBigInteger(1, n - 1);
            return r;
        }

        public static BigInteger CalculateX(BigInteger r, BigInteger n)
        {
            BigInteger x = BigInteger.ModPow(r, 2, n);
            return x;
        }

        public static int GenerateE()
        {
            var sides = new int[] { 0, 1 };
            int e = sides[random.Next(sides.Length)];
            return e;
        }

        public static BigInteger CalculateY(BigInteger r, BigInteger s, BigInteger n, BigInteger e)
        {
            if (e == 1)
                return r * s % n;
            else
                return r;
        }


        public struct VerifyResultY
        {
            public bool success;
            public string reason;
        }

        public static VerifyResultY VerifyY(BigInteger y, BigInteger n, BigInteger x, BigInteger v, int e)
        {
            if (y == 0) 
            {
                return new VerifyResultY
                {
                    success = false,
                    reason = $"y = {y}",
                };
            }

            BigInteger left = BigInteger.ModPow(y, 2, n);
            BigInteger right = x * BigInteger.Pow(v, e) % n;

            bool success;
            string reason;

            if (left == right)
            {
                success = true;
                reason = $"y^2 = {left}  ==  x * v^e mod n = {right}";
            }
            else
            {
                success = false;
                reason = $"y^2 = {left}  !=  x * v^e mod n = {right}";
            }
            return new VerifyResultY
            {
                success = success,
                reason = reason,
            };
        }
    }

    static class Log
    {
        const string format = "HH:mm:ss.ffffff";

        public static string Info(string entity, string info)
        {
            if (entity != null)
            {
                return $"[ {DateTime.Now.ToString(format)} ]    [ {entity} ]    {info}";
            }
            return $"[ {DateTime.Now.ToString(format)} ]    {info}";
        }
    }

    public delegate void HandleLog(string log);

    class TrustedCenter
    {
        const string entity = "Доверительный центр";

        private BigInteger p;
        private BigInteger q;
        private BigInteger n;

        HandleLog h;

        public TrustedCenter(int length, HandleLog handle)
        {
            h = handle;

            h(Log.Info(entity, "Объект создан"));

            p = Auth.GeneratePrime(length);
            h(Log.Info(entity, $"Сгенерировано простое число  p = {p} порядка {length}"));

            q = Auth.GeneratePrime(length);
            h(Log.Info(entity, $"Сгенерировано простое число  q = {q} порядка {length}"));
        }

        public BigInteger CalculateN()
        {
            n = p * q;
            h(Log.Info(entity, $"Вычислено общедоступное число  n = p * q = {p} * {q} = {n}"));
            return n;
        }
    }


    class PeggyProver
    {
        const string entity = "Пэгги";

        private BigInteger n;

        private BigInteger s;
        private BigInteger v;

        private BigInteger r;

        HandleLog h;

        public PeggyProver(BigInteger n, HandleLog handle)
        {
            h = handle;

            h(Log.Info(entity, "Объект создан"));

            this.n = n;
            h(Log.Info(entity, $"Получено общедоступное число n = {n}"));

            s = Auth.ChooseS(this.n);
            h(Log.Info(entity, $"Выбрано секретное число s = {s} ∈ [{1}, {n}]"));

            v = Auth.CalculateV(s, this.n);
            h(Log.Info(entity, $"Вычислено значение v = s^2 mod n = {s}^2 mod {n} = {v}"));

            h(Log.Info(entity, $"Установлено s = {s} секретный ключ и v = {v} публичный ключ"));
        }

        public BigInteger ProvideV()
        {
            h(Log.Info(entity, $"Передан публичный ключ v = {v}"));
            return v;
        }

        public BigInteger CalculateX()
        {
            r = Auth.ChooseR(n);
            h(Log.Info(entity, $"Выбрано обязательство r = {r} ∈ [{1}, {n} - 1]"));


            BigInteger x = Auth.CalculateX(r, n);
            h(Log.Info(entity, $"Вычислено свидетельство x = r^2 mod n = {r}^2 mod {n} = {x}"));

            h(Log.Info(entity, $"Свидетельство x = {x} передано"));
            return x;
        }

        public BigInteger CalculateY(BigInteger e)
        {
            BigInteger y = Auth.CalculateY(r, s, n, e);
            h(Log.Info(entity, $"Вычислен ответ y = r * s^c = {r} * {s}^{e} = {y}"));

            h(Log.Info(entity, $"Ответ y = {y} передан"));
            return y;
        }
    }

    public class VictorVerifier
    {
        const string entity = "Виктор";

        private BigInteger n;
        private BigInteger x;

        private int e;
        private BigInteger v;

        private bool verified;

        HandleLog h;

        public VictorVerifier(BigInteger n, BigInteger v, HandleLog handle)
        {
            h = handle;
            h(Log.Info(entity, "Объект создан"));

            this.n = n;
            h(Log.Info(entity, $"Получено общедоступное число n = {n}"));

            this.v = v;
            h(Log.Info(entity, $"Получен публичный ключ v = {v}"));
        }

        public int GenerateE(BigInteger x)
        {
            this.x = x;
            h(Log.Info(entity, $"Свидетельство x = {x} получено"));

            e = Auth.GenerateE();
            h(Log.Info(entity, $"Сгенерирован вызов e"));

            h(Log.Info(entity, $"Вызов e = {e} передан"));
            return e;
        }

        public bool VerifyY(BigInteger y)
        {
            h(Log.Info(entity, $"Ответ y = {y} получен"));

            var verified = Auth.VerifyY(y, n, x, v, e);

            if (verified.success)
                h(Log.Info(entity, $"Подтвердил подлинность секрета. Причина: {verified.reason}"));
            else
                h(Log.Info(entity, $"Опроверг подлинность секрета. Причина: {verified.reason}"));

            this.verified = verified.success;

            return this.verified;
        }

        public void InfoVerified(int r, int rounds)
        {
            if (!verified)
                h(Log.Info(entity, $"Подлинность секрета на раунде не подтверждена. Раунд = {r}. Всего раундов = {rounds}"));
            else 
                h(Log.Info(entity, $"Подлинность секрета на раунде подтверждена. Раунд = {r}. Всего раундов = {rounds}"));
        }
    }

    public static class FiatShamirProtocol
    {
        const string entity = "Протокол аутентификации";

        static HandleLog h;

        public static bool DoAuth(int length, int rounds, HandleLog handle)
        {
            bool authenticated = false;
            h = handle;

            Task.Run(() =>
            {
                var trustedCenter = new TrustedCenter(length, h);
                BigInteger n = trustedCenter.CalculateN();

                var peggyProver = new PeggyProver(n, h);
                BigInteger v = peggyProver.ProvideV();

                var victorVerifier = new VictorVerifier(n, v, h);

                for (int r = 1; r <= rounds; r++)
                {
                    BigInteger x = peggyProver.CalculateX();
                    int e = victorVerifier.GenerateE(x);

                    BigInteger y = peggyProver.CalculateY(e);
                    bool verified = victorVerifier.VerifyY(y);

                    if (!verified)
                    {
                        h(Log.Info(entity, $"Подлинность секрета на раунде не подтверждена. Раунд = {r}. Всего раундов = {rounds}"));
                        authenticated = false;
                        break;
                    }
                    h(Log.Info(entity, $"Подлинность секрета на раунде подтверждена. Раунд = {r}. Всего раундов = {rounds}"));
                }

                h(Log.Info(entity, $"Подлинность секрета подтверждена на всех раундах. Всего раундов = {rounds}"));
                authenticated = true;

            }).Wait();

            return authenticated;
        }
    }
}
