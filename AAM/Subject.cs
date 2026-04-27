using System.Collections.Generic;

namespace AAM
{
    public class Subject
    {
        public string Name { get; set; }
        public List<double> SorGrades { get; set; } = new List<double>();
        public List<int> SorMaxScores { get; set; } = new List<int>();
        public double SochGrade { get; set; }
        public int SochMaxScore { get; set; }
        // периодические свойства
        public int Year { get; set; }
        public string Quarter { get; set; }

        public double CalculatePercentage()
        {
            double earned = SochGrade;
            double max = SochMaxScore;
            for (int i = 0; i < SorGrades.Count; i++)
            {
                earned += SorGrades[i];
                max += SorMaxScores[i];
            }
            return (max > 0) ? (earned / max) * 100 : 0;
        }

        public static double PercentageToNumericGrade(double percent)
        {
            if (percent >= 85) return 5.0;
            if (percent >= 65) return 4.0;
            if (percent >= 45) return 3.0;
            if (percent >= 25) return 2.0;
            return 1.0;
        }

        public static double PercentageToNumericGradeContinuous(double percent)
        {
            // линейное отображение процента в шкалу 1..5
            double grade = 1.0 + (percent / 100.0) * 4.0;
            if (grade > 5.0) grade = 5.0;
            if (grade < 1.0) grade = 1.0;
            return grade;
        }
    }
}
