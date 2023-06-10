namespace ChallengeApp
{
    public abstract class Person : IEmployee
    {
        public Person(string name, string surname, char sex)
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public char Sex { get; private set; }

        public event EmployeeBase.GradeAddedDelegate GradeAdded;

        public void AddGrade(float grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(string grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(char grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(double grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(long grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(int grade)
        {
            throw new NotImplementedException();
        }

        public Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }
    }
}
