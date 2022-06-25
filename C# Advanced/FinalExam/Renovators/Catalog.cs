using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Catalog
    {
        public List<Renovator> renovators { get; set; }

        public string Name { get; set; }
        public int NeededRenovators { get; set; }
        public string Project { get; set; }

        public Catalog(string name, int neededRenovators, string project)
        {
            this.renovators = new List<Renovator>();
            this.Name = name;
            this.NeededRenovators = neededRenovators;
            this.Project = project;
        }

        public int Count => this.renovators.Count;

        public string AddRenovator(Renovator renovator)
        {
            if (string.IsNullOrEmpty(renovator.Name) || string.IsNullOrEmpty(renovator.Type))
            {
                return "Invalid renovator's information";
            }
            else if (renovators.Count >= this.NeededRenovators)
            {
                return "Renovators are no more needed";
            }
            else if (renovator.Rate > 350)
            {
                return "Invalid renovator's rate";
            }

            renovators.Add(renovator);

            return $"Successfully added {renovator.Name} to the catalog.";
        }

        public bool RemoveRenovator(string name)
        {

            foreach (var renovator in renovators)
            {
                if (renovator.Name == name)
                {
                    return true;
                }
            }
            return false;
        }

        public int RemoveRenovatorBySpecialty(string type)
        {
            int count = 0;



            for(int i = 0; i < renovators.Count; i++)
            {
                if (renovators[i].Type == type)
                {
                    renovators.Remove(renovators[i]);
                    count++;
                }
            }

            return count;
        }

        public Renovator HireRenovator(string name)
        {
            
            foreach (var renovator in renovators)
            {
                if (renovator.Name == name)
                {
                    renovator.Hired = true;
                    return renovator;
                }
            }

            return null;
        }

        public List<Renovator> PayRenovators(int days)
        {
            List<Renovator> paidRenovators = renovators.Where(r => r.Days >= days).ToList();

            return paidRenovators;
        }

        public string Report()
        {
            List<Renovator> notHired = renovators.Where(r => r.Hired == false).ToList();

            return
                $"Renovators available for Project {this.Project}:" + Environment.NewLine +
                $"{string.Join(Environment.NewLine, notHired)}";
        }
    }

}
