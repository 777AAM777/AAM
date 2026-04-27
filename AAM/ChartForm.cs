using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AAM
{
    public partial class ChartForm : Form
    {
        public ChartForm(List<Subject> subjects)
        {
            InitializeComponent();
            Populate(subjects);
        }

        public ChartForm()
        {
            InitializeComponent();
        }

        public void Populate(List<Subject> subjects)
        {
            listView1.Items.Clear();

            // Заполним таблицу
            foreach (var sub in subjects)
            {
                var numericGrade = Subject.PercentageToNumericGradeContinuous(sub.CalculatePercentage());
                string schoolYear = $"{sub.Year}-{sub.Year + 1}";
                var item = new ListViewItem(new string[] { sub.Name, $"{sub.CalculatePercentage():F1}%", $"{numericGrade:F2}", schoolYear, sub.Quarter });
                listView1.Items.Add(item);
            }

            // Построим график: для каждой четверти создадим серию и добавим точки для предметов
            try
            {
                chart1.Series.Clear();
                var chartArea = chart1.ChartAreas[0];
                chartArea.AxisY.Minimum = 0;
                chartArea.AxisY.Maximum = 100;
                chartArea.AxisY.Interval = 10;
                chartArea.AxisX.Interval = 1;
                chartArea.AxisX.LabelStyle.Angle = -45;
                chartArea.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;

                // Получим список уникальных периодов (год+четверть) в порядке
                var periods = subjects
                    .Select(s => new { s.Year, s.Quarter })
                    .Distinct()
                    .OrderBy(p => p.Year)
                    .ThenBy(p => p.Quarter)
                    .ToList();

                // Список уникальных предметов (фиксированный порядок по алфавиту для стабильности)
                var subjectsNames = subjects.Select(s => s.Name).Distinct().OrderBy(n => n).ToList();

                // Подписи по оси X — периоды
                chartArea.AxisX.CustomLabels.Clear();
                for (int i = 0; i < periods.Count; i++)
                {
                    double from = i - 0.5;
                    double to = i + 0.5;
                    string label = $"{periods[i].Year}-{periods[i].Year + 1} Q{periods[i].Quarter}";
                    var lab = new System.Windows.Forms.DataVisualization.Charting.CustomLabel(from, to, label, 0, System.Windows.Forms.DataVisualization.Charting.LabelMarkStyle.LineSideMark);
                    chartArea.AxisX.CustomLabels.Add(lab);
                }

                int colorIdx = 0;
                var palette = new System.Drawing.Color[] { System.Drawing.Color.Blue, System.Drawing.Color.Red, System.Drawing.Color.Green, System.Drawing.Color.Orange, System.Drawing.Color.Purple };

                // Создаём серию для каждого предмета — линии по периодам
                for (int subjIndex = 0; subjIndex < subjectsNames.Count; subjIndex++)
                {
                    var name = subjectsNames[subjIndex];
                    var series = chart1.Series.Add(name);
                    series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    series.BorderWidth = 2;
                    series.Color = palette[colorIdx % palette.Length];
                    series.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
                    series.MarkerSize = 6;
                    for (int i = 0; i < periods.Count; i++)
                    {
                        var p = periods[i];
                        var entries = subjects.Where(s => s.Name == name && s.Year == p.Year && s.Quarter == p.Quarter).ToList();
                        double val = double.NaN;
                        if (entries.Count > 0)
                        {
                            // усредняем значения для предмета в данном периоде, если их несколько
                            val = entries.Average(e => e.CalculatePercentage());
                        }
                        // Если всего один период, сместим X-координаты серий немного, чтобы точки не накладывались
                        double x = i;
                        if (periods.Count == 1 && subjectsNames.Count > 1)
                        {
                            double jitter = 0.15; // небольшое смещение
                            double center = (subjectsNames.Count - 1) / 2.0;
                            x = i + (subjIndex - center) * jitter;
                        }
                        int idxPt = series.Points.AddXY(x, val);
                        var dp = series.Points[idxPt];
                        dp.ToolTip = double.IsNaN(val) ? "нет данных" : $"{name}: {val:F1}%";
                    }

                    colorIdx++;
                }

                // Отобразим среднюю оценку по всем предметам (непрерывная шкала)
                double overallAvg = subjects.Select(s => Subject.PercentageToNumericGradeContinuous(s.CalculatePercentage())).DefaultIfEmpty(0).Average();
                lblOverall.Text = $"Средняя оценка по всем предметам: {overallAvg:F2}";
                chart1.Legends[0].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            }
            catch { }
        }
    }
}
