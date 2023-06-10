namespace ChallengeApp
{
    public class SupervisorInMemory : EmployeeBase
    {
        public override event GradeAddedDelegate GradeAdded;

        private List<float> grades = new List<float>();

        public SupervisorInMemory(string name, string surname)
           : base(name, surname)
        {
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);

                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
        }

        public override void AddGrade(string grade)
        {
            {
                switch (grade)
                {
                    case "6":
                        AddGrade(100);
                        break;
                    case "-6":
                    case "6-":
                        AddGrade(95);
                        break;
                    case "+5":
                    case "5+":
                        AddGrade(85);
                        break;
                    case "5":
                        AddGrade(80);
                        break;
                    case "-5":
                    case "5-":
                        AddGrade(75);
                        break;
                    case "+4":
                    case "4+":
                        AddGrade(65);
                        break;
                    case "4":
                        AddGrade(60);
                        break;
                    case "-4":
                    case "4-":
                        AddGrade(55);
                        break;
                    case "+3":
                    case "3+":
                        AddGrade(45);
                        break;
                    case "3":
                        AddGrade(40);
                        break;
                    case "-3":
                    case "3-":
                        AddGrade(35);
                        break;
                    case "+2":
                    case "2+":
                        AddGrade(25);
                        break;
                    case "2":
                        AddGrade(20);
                        break;
                    case "-2":
                    case "2-":
                        AddGrade(15);
                        break;
                    case "+1":
                    case "1+":
                        AddGrade(5);
                        break;
                    case "1":
                        AddGrade(0);
                        break;
                    default:
                        throw new Exception("Wrong Figure. Type a grade between 1-6.");
                }
            }
        }

       
        public override void AddGrade(double grade)
        {
            float valueDouble = (float)grade;
            this.AddGrade(valueDouble);
        }
        public override void AddGrade(int grade)
        {
            float gradeAsInt = grade;
            this.AddGrade(gradeAsInt);
        }

        public override void AddGrade(long grade)
        {
            float valueLong = (float)grade;
            this.AddGrade(valueLong);
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= this.grades.Count;

            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }
            return statistics;
        }

        
    }
}