using System;
using System.Windows.Forms;

namespace AAM
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
            rtbHelp.Text = "Инструкция:\n1. Выберите предмет\n2. Укажите количество СОР\n3. Введите баллы\n4. Нажмите Расчет.";
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            string video = Application.StartupPath + "\\tutorial.mp4";
            if (System.IO.File.Exists(video))
            {
                MessageBox.Show("Воспроизведение видео доступно только если вы добавите Windows Media Player COM-контрол через Toolbox (Choose Items -> COM Components -> Windows Media Player).");
            }
            else
            {
                MessageBox.Show("Файл tutorial.mp4 не найден в папке приложения.");
            }
        }
    }
}
