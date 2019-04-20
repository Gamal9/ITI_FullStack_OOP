using System;
using System.Collections.Generic;
using System.Text;

namespace DealingWithClasses
{
    public class Company
    {
        private const string CompName = "Iti FullStack .NET";

        public int ID { get; set; }
        public Department[] Deparments { get; set; }

        public void DisplayCompany()
        {
            Console.Clear();
            bool ch = false;
            Console.WriteLine($"The Company Name IS {CompName} \n\t Departments => ");
            if(Deparments!=null)
            {
                foreach (var item in Deparments)
                {
                    if(item!=null)
                    {
                        ch = true;
                        item.DisplayAll();
                    }
                }
            }
            
            if(ch==false)
            {
                
                Console.WriteLine("\t No Departments Inside Company");
            }
        }

    }
}
