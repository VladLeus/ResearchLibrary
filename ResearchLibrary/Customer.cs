using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResearchLibrary
{
    [Serializable]
    public class Customer
    {
        private string organizationName;
        private string researchTheme;
        private int cost;

        public string OrganizationName
        {
            get => organizationName;
            set => organizationName = value;
        }

        public string ResearchTheme
        {
            get => researchTheme;
            set => researchTheme = value;
        }

        public int Cost
        {
            get => cost;
            set
            {
                if (value < 0)
                    throw new ArgumentException();
                cost = value;
            }
        }

        public override string ToString()
        {
            return $"Organization name: {organizationName}. Research theme: {researchTheme}. It's cost: {cost}";
        }

        public override bool Equals(object? obj)
        {
            return obj is Customer customer &&
                   organizationName == customer.organizationName &&
                   researchTheme == customer.researchTheme &&
                   cost == customer.cost;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(organizationName, researchTheme, cost);
        }
    }
}
