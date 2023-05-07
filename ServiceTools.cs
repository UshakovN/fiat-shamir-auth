using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CommonForms
{
    public static class ServiceTools
    {
        private readonly static string format = "HH-mm-ss_ffffff";
        private readonly static string filenameTemplate = "fiat-shamir created_at {0}";

        private readonly static int thresholdLenght = 10;
        private readonly static int thresholdRounds = 300;

        public readonly static string successTitle = "Успешно";
        public readonly static string successInfo = "Субъект был аутентифицирован\nПодробнее в журнале событий";

        public readonly static string failTitle = "Не успешно";
        public readonly static string failInfo = "Субъект не был аутентифицирован\nПодробнее в журнале событий";

        public readonly static string errNonPositiveLenght = "Порядок инициализирующих простых чисел p и q генерируемых доверенным центром должен быть положительным целым числом";
        public readonly static string errNonPositiveRounds = "Количество раундов протокола должно быть положительным целым числом";
        public readonly static string errorTitle = "Ошибка";

        public readonly static string warnOverheadLenght = $"Ограничение ресурсов вычислительного устройства\nВо избежание зависания следует выставить порядок чисел p и q не более {thresholdLenght}";
        public readonly static string warnOverheadRounds = $"Ограничение ресурсов вычислительного устройства\nВо избежание зависания следует выставить количество раундов протокола не более {thresholdRounds}";
        public readonly static string warnTitle = "Предупреждение";

        public readonly static string modeInfoTitle = "Инфо";
        public readonly static string modeAutoInfo = BuildInfoForModeAuto();
        public readonly static string modeManualInfo = BuildInfoForModeManual();

        public static string GetNowTime()
        {
            string time = DateTime.Now.ToString(ServiceTools.format);
            return time;
        }

        public static void HandleLog(string log, ListBox listbox)
        {
            listbox.Items.Add(log);
        }

        public static void ShowInfoForModeAuto()
        {
            MessageBox.Show(
                modeAutoInfo,
                modeInfoTitle,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        public static void ShowInfoForModeManual()
        {
            MessageBox.Show(
                modeManualInfo,
                modeInfoTitle,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private static string BuildInfoForModeAuto()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Информационная справка\n");
            sb.AppendLine("Для выполнения протокола аутентификации Фиата-Шамира следует нажать соответствующую кнопку\n");
            sb.AppendLine("Количество раундов протокола должно быть положительным целым числом\n");
            sb.AppendLine("Порядок инициализирующих простых чисел p и q генерируемых доверенным центром должен быть положительным целым числом\n");
            sb.AppendLine("Для очистки содержимого журнала событий можно воспользоваться контекстным меню правой кнопки мыши\n");
            sb.AppendLine("Конец информационной справки");
            return sb.ToString();
        }

        private static string BuildInfoForModeManual()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Информационная справка\n");
            sb.AppendLine("Для выполнения протокола аутентификации Фиата-Шамира необходимо взаимодействовать с элементами управления согласно указанной в них нумерации\n");
            sb.AppendLine("Имена участников протокола указаны над соответствующими панелями управления\n");
            sb.AppendLine("Действия принимаемые участниками протокола осуществляются при помощи элементов управления в соотвествующем блоке\n");
            sb.AppendLine("Количество раундов протокола должно быть положительным целым числом\n");
            sb.AppendLine("Порядок инициализирующих простых чисел p и q генерируемых доверенным центром должен быть положительным целым числом\n");
            sb.AppendLine("Для очистки содержимого журнала событий можно воспользоваться контекстным меню правой кнопки мыши\n");
            sb.AppendLine("Конец информационной справки");
            return sb.ToString();
        }

        public static bool ValidateContantsLenght(int length)
        {
            if (length <= 0)
            {
                MessageBox.Show(
                    errNonPositiveLenght,
                    errorTitle,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
            if (length > thresholdLenght)
            {
                MessageBox.Show(
                    warnOverheadLenght,
                    warnTitle,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }
            return true;
        }

        public static bool ValidateRoundsCount(int rounds)
        {
            if (rounds <= 0)
            {
                MessageBox.Show(
                    errNonPositiveRounds,
                    errorTitle,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
            if (rounds > thresholdRounds)
            {
                MessageBox.Show(
                    warnOverheadRounds,
                    warnTitle,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }
            return true;
        }

        private static string FormLogFilename(string time)
        {
            return string.Format(filenameTemplate, time);
        }

        public static void FormLogFile(ListBox listbox, string time)
        {
            try
            {
                var saveDialog = new SaveFileDialog
                {
                    InitialDirectory = Application.StartupPath,
                    Title = "Создание файла журнала",
                    Filter = "Файлы журнала|*.log",
                    FileName = FormLogFilename(time),
                };
                if (saveDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                string filename = saveDialog.FileName;

                using (var writer = new StreamWriter(File.Open(filename, FileMode.Create)))
                {
                    foreach (var item in listbox.Items)
                    {
                        writer.WriteLine(item.ToString());
                    }
                }

                MessageBox.Show(
                    "Файл журнала успешно создан",
                    "Файл создан",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show(
                   "Не удалось создать файл журнала",
                   "Ошибка",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }

        public static void LoadLogFile(ListBox listbox)
        {
            try
            {
                var openDialog = new OpenFileDialog
                {
                    Title = "Открытие файла журнала",
                    Filter = "Файлы журнала|*.log",
                };
                if (openDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                string filename = openDialog.FileName;


                using (var reader = new StreamReader(File.Open(filename, FileMode.Open)))
                {
                    for (; ; )
                    {
                        var line = reader.ReadLine();

                        if (line == null)
                            break;

                        listbox.Items.Add(line);
                    }
                }

                MessageBox.Show(
                    "Файл журнала успешно загружен",
                    "Файл загружен",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show(
                   "Не удалось загрузить файл журнала",
                   "Ошибка",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }

        public static void ClearEventsLog(ListBox listbox)
        {
            listbox.Items.Clear();
        }
    }
}
