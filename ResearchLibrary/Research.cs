using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResearchLibrary
{
    [Serializable]
    public class Research
    {
        private Customer customer;
        private DateTime signingDate;
        private List<Publication> publications;

        public Customer Customer
        {
            get => customer;
            set => customer = value;
        }

        public DateTime SigningDate
        {
            get => signingDate;
            set => signingDate = value;
        }

        public List<Publication> Publications
        {
            get => publications;
            set => publications = value;
        }

        public bool RemovePublication(Publication publication)
        {
            return publications.Remove(publication);
        }

        public void AddPublication(Publication publication)
        {
            publications.Add(publication);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder($"{customer.ResearchTheme}");
            foreach (Publication publication in publications)
            {
                sb.Append(publication);
            }
            return sb.ToString();
        }

        public string ToShortString()
        {
            return $"Theme: {customer.ResearchTheme}. Total publications: {publications.Count}";
        }

        public override bool Equals(object? obj)
        {
            return obj is Research research &&
                   EqualityComparer<Customer>.Default.Equals(customer, research.customer) &&
                   signingDate == research.signingDate &&
                   EqualityComparer<List<Publication>>.Default.Equals(publications, research.publications);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(customer, signingDate, publications);
        }
    }
}
