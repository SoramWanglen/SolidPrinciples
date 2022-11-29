using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrn
{
    public class ChefEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        
    }
    public class ChefDomain
    {
        private readonly ChefDataProcessor chefDataProcessor;
        public ChefDomain(ChefDataProcessor chefDataProcessor)
        {
            this.chefDataProcessor = chefDataProcessor;
        }
        public ChefEntity CreateChef(ChefEntity chef)
        {
            return chefDataProcessor.AddChef(chef);
        }
        public ChefEntity GetChef(int id)
        {
            return chefDataProcessor.GetChef(id);
        }
    }
    public class ChefDataProcessor
    {
        public ChefEntity GetChef(int id)
        {
            return new ChefEntity();
        }
        public ChefEntity AddChef(ChefEntity chef)
        {
            return new ChefEntity();
        }

    }
    class ResDependencyInversionPrinciple
    {
        public void Show()
        {
            Console.WriteLine("Interface Segregation!");
        }
    }
}
