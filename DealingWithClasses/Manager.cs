using System;
using System.Collections.Generic;
using System.Text;

namespace DealingWithClasses
{
    public class Manager
    {
        public Manager()
        {

        }
        public Manager(Manager mng)
        {
            ManagerID = mng.ManagerID;
            ManagerName = mng.ManagerName;
            ManagerSalary = mng.ManagerSalary;
        }
        public int ManagerID { get; set; }
        public string ManagerName { get; set; }
        public float ManagerSalary { get; set; }
    }
}
