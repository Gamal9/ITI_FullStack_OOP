using System;
using System.Collections.Generic;
using System.Text;

namespace DealingWithStructs
{
    public struct Empolyee
    {

        public Empolyee(Empolyee emp)
        {
            _id = emp.ID;
            _name = emp.Name;
            _salary = emp.Salary;
            _clients = emp.Clients;
        }

        private int _id;
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private float _salary;
        public float Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        private Client[] _clients;
        public Client[] Clients
        {
            get { return _clients; }
            set { _clients = value; }
        }

        public void DisplayAll()
        {
            if (ID!=0)
            {
                Console.WriteLine($"Empolyee ID = {ID} - Name = {Name} - Salary = {Salary} \n \t Clients => ");
                for (int i = 0; i < Clients.Length; i++)
                {
                    if (Clients[i].ID != 0)
                    {
                        Clients[i].DisplayClient();
                    }
                    
                }
            }
        }



    }
}
