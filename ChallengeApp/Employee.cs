namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();

        public Employee(string name)
        {
            Name = name;
        }

        public Employee(string Name, string Surname)

        {
            this.Name = Name;
            this.Surname = Surname;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {
            this.grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(grade, statistics.Max);
                statistics.Min = Math.Min(grade, statistics.Min);
                statistics.Average += grade;
            }
           
            statistics.Average /= this.grades.Count;
            return statistics;
        }
    }
}