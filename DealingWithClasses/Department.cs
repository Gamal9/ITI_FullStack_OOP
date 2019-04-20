using System;
using System.Collections.Generic;
using System.Text;

namespace DealingWithClasses
{
    public class Department
    {
        public Department()
        {

        }
        public Department(Department dep ,string depName)
        {
            DepID = dep.DepID;
            EmpolyeesArray = dep.EmpolyeesArray;
            DepManager = dep.DepManager;
            DepID = dep.DepID;
            _depName = depName;
        }

        private readonly string _depName;
        public string DepName
        {
            get { return _depName; }
        }


        public int DepID { get; set; }
        public Manager DepManager { get; set; }
        public Empolyee[] EmpolyeesArray { get; set; }

        public void DisplayAll()
        {
            bool ch = false;
            Console.WriteLine($"Department ID = {DepID} - Department Name = {DepName} ");
            string str = (DepManager == null) ? "No Have Manager" : "Manager Name is => "+DepManager.ManagerName;
            Console.WriteLine(str);
            if(EmpolyeesArray !=null)
            {
                foreach (var item in EmpolyeesArray)
                {
                    if(item !=null)
                    {
                        ch = true;
                        item.DisplayAll();
                    }
                }
            }
            
            if(ch == false)
            {
                Console.WriteLine("No Empoyees");
            }
        }

        ~Department()
        {
            Console.WriteLine($"Department {DepID} Is Destroied");
        }
    }
}
