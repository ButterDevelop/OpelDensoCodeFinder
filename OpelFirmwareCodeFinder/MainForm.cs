using System;
using System.IO;
using System.Windows.Forms;

namespace OpelDensoCodeFinder
{
    public partial class MainForm : Form
    {
        public string FirmwarePath = "";

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonOpenFirmware_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "BIN files (*.bin)|*.bin|All files (*.*)|*.*",
                Title  = "Select a firmware file"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FirmwarePath = openFileDialog.FileName;
                textBoxOpenFirmware.Text = FirmwarePath;
            }
        }

        private void buttonFindPIN_Click(object sender, EventArgs e)
        {
            if (FirmwarePath.Length == 0)
            {
                MessageBox.Show("Вы не указали файл прошивки!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBoxVINCode.Text.Length == 0)
            {
                MessageBox.Show("Вы не указали VINCode!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!File.Exists(FirmwarePath))
            {
                MessageBox.Show("Не удаётся получить доступ к файлу прошивки! Он точно указан правильно?", "Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var processor = new BinHexProcessor(FirmwarePath, textBoxVINCode.Text);
            string result = processor.Process();
            textBoxPINCode.Text = result;
        }
    }
}
