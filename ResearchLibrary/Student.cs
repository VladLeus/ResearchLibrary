namespace ResearchLibrary
{
    [Serializable]
    public class Student
    {
        private string name;
        private string surName;
        DateTime enrollmentYear;

        public string Name 
        { 
            get => name;  
            set => name = value;  
        }
        public string Surname
        {
            get => surName;
            set => surName = value;
        }
        
        public DateTime EnrollmentYear
        {
            get => enrollmentYear;
            set => enrollmentYear = value;
        }

        public override string ToString()
        {
            return $"{name} {surName}. Enrolment year: {enrollmentYear.Date}";
        }

        public override bool Equals(object? obj)
        {
            return obj is Student student &&
                   name == student.name &&
                   surName == student.surName &&
                   enrollmentYear == student.enrollmentYear;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(name, surName, enrollmentYear);
        }
    }
}