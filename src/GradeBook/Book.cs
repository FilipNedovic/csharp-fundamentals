namespace GradeBook
{
    public class Book
    {
        // Explicit constructor
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }
        // Instance member
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;
            foreach (double grade in grades)
            {
                result.High = Math.Max(grade, result.High);
                result.Low = Math.Min(grade, result.Low);
                result.Average += grade;
            }

            result.Average /= grades.Count;

            return result;
        }

        // Field definition
        private List<double> grades;
        // Public member has upper-case name
        public string Name;
    }
}