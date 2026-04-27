using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AAM
{
    public partial class MainForm : Form
    {
        List<Subject> allSubjects = new List<Subject>();

        public MainForm()
        {
            InitializeComponent();
            cmbSubjects.Items.AddRange(new string[] { "Математика", "Физика", "История", "Информатика", "Русский язык", "Казахский язык", "Английский язык", "История Казахстана", "Всемирная история", "Химия", "Биология", "Искусство", "География", "Физическая культура" });
            numSorCount.Value = 1;
            cmbQuarter.Items.AddRange(new string[] { "1", "2", "3", "4" });
            cmbQuarter.SelectedIndex = 0;
            // Создаём начальные поля СОР сразу при загрузке (если значение по умолчанию = 1)
            numSorCount_ValueChanged(null, EventArgs.Empty);
        }

        private void numSorCount_ValueChanged(object sender, EventArgs e)
        {
            pnlSor.Controls.Clear();
            int count = (int)numSorCount.Value;
            for (int i = 0; i < count; i++)
            {
                Label lbl = new Label { Text = $"СОР {i + 1} (балл/макс):", Top = i * 30, Left = 5, Width = 110 };
                NumericUpDown score = new NumericUpDown { Name = $"score{i}", Top = i * 30, Left = 120, Width = 60, Maximum = 100, DecimalPlaces = 1 };
                NumericUpDown max = new NumericUpDown { Name = $"max{i}", Top = i * 30, Left = 190, Width = 60, Value = 10, Maximum = 100 };
                pnlSor.Controls.Add(lbl);
                pnlSor.Controls.Add(score);
                pnlSor.Controls.Add(max);
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbSubjects.Text))
            {
                MessageBox.Show("Выберите предмет.");
                return;
            }

            Subject sub = new Subject { Name = cmbSubjects.Text };
            // период
            sub.Quarter = cmbQuarter.SelectedItem?.ToString() ?? "1";
            // представляем год как интервал учебного года, например 2024 -> "2024-2025"
            int startYear = (int)numYear.Value;
            sub.Year = startYear;
            // В ChartForm будем отображать как строку "2024-2025"
            int count = (int)numSorCount.Value;

            for (int i = 0; i < count; i++)
            {
                var scoreControl = pnlSor.Controls.Find($"score{i}", false).FirstOrDefault() as NumericUpDown;
                var maxControl = pnlSor.Controls.Find($"max{i}", false).FirstOrDefault() as NumericUpDown;
                if (scoreControl == null || maxControl == null) continue;
                sub.SorGrades.Add((double)scoreControl.Value);
                sub.SorMaxScores.Add((int)maxControl.Value);
            }

            sub.SochGrade = (double)numSochScore.Value;
            sub.SochMaxScore = (int)numSochMax.Value;

            double percent = sub.CalculatePercentage();
            allSubjects.Add(sub); // Сохраняем в список
            lblResult.Text = $"Процент: {percent:F1}%";

            // Ветвление
            if (percent >= 85) lblGrade.Text = "Оценка: 5";
            else if (percent >= 65) lblGrade.Text = "Оценка: 4";
            else lblGrade.Text = "Оценка: 3";
        }

        private void btnGoToChart_Click(object sender, EventArgs e)
        {
            if (allSubjects.Count == 0) return;
            ChartForm frm = new ChartForm(allSubjects);
            frm.Show();
        }

        private void btnHelp_Click(object sender, EventArgs e) => new HelpForm().Show();
    }
}
