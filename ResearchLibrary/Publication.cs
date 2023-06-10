using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResearchLibrary
{
    [Serializable]
    public class Publication
    {
        private Student student;
        private ScientificAchivments scientificAchivments;

        public Student Student
        {
            get => student;
            set => student = value;
        }
        public ScientificAchivments ScientificAchivments
        {
            get => scientificAchivments;
            set => scientificAchivments = value;
        }

        public override string? ToString()
        {
            return $"Student: {student}. Achivments: {scientificAchivments}";
        }

        public override bool Equals(object? obj)
        {
            return obj is Publication publication &&
                   EqualityComparer<Student>.Default.Equals(student, publication.student) &&
                   scientificAchivments == publication.scientificAchivments;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(student, scientificAchivments);
        }
    }
}
