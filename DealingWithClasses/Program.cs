using System;

namespace DealingWithClasses
{
    class Program
    {
        public static bool IdChecker(Department[] Deps, int id)
        {
            bool checker = true;
            if (id > Deps.Length || id <= 0)
            {
                Console.WriteLine($"Wrong ID Try Again !! The ID Start From 1 And End With {Deps.Length}");
                return false;
            }
            foreach (var item in Deps)
            {
                if(item == null)
                {
                    checker=true;
                }
                else if (item.DepID == id)
                {
                    Console.WriteLine($"This ID Is Used Before !! The ID Start From 1 And End With {Deps.Length}");
                    return false;
                }
            }
            return checker;
        }

        public static bool DepNameChecker(Department[] Deps, string str)
        {
            bool checker=true;
            foreach (var item in Deps)
            {
                if (item == null)
                {
                    checker=true;
                }
                else if (item.DepName == str)
                {
                    Console.WriteLine($"This Name [{str}] Is Used Before !! ");
                    return false;
                }
            }
            return checker;
        }

        public static bool IdChecker(Empolyee[] emps, int id)
        {
            bool checker = true;
            if (id > emps.Length || id <= 0)
            {
                Console.WriteLine($"Wrong ID Try Again !! The ID Start From 1 And End With {emps.Length}");
                return false;
            }
            foreach (var item in emps)
            {
                if (item == null)
                {
                    checker = true;
                }
                else if (item.ID == id)
                {
                    Console.WriteLine($"This ID Is Used Before !! The ID Start From 1 And End With {emps.Length}");
                    return false;
                }
            }
            return checker;
        }

        public static bool IdChecker(Client[] Clients, int id)
        {
            bool checker = true;
            if (id > Clients.Length || id <= 0)
            {
                Console.WriteLine($"Wrong ID Try Again !! The ID Start From 1 And End With {Clients.Length}");
                return false;
            }
            foreach (var item in Clients)
            {
                if (item == null)
                {
                    checker = true;
                }
                else if (item.ID == id)
                {
                    Console.WriteLine($"This ID Is Used Before !! The ID Start From 1 And End With {Clients.Length}");
                    return false;
                }
            }
            return checker;
        }

        static void Main(string[] args)
        {
            Company comp = new Company();
            int count,index;
            bool check1 = true;
            comp.ID = 1;         
            do
            {
                Console.WriteLine("Enter Count Of Department Inside Company :- ");
                count = int.Parse(Console.ReadLine());
                if (count > 0)
                    check1 = false;
            } while (check1);
            check1 = true;
            Department[] Deps = new Department[count];
            int option = 0;
            do
            {
                Console.WriteLine("Options :- \n1- Add New Department \n2- Display The Company Data \n3-Exit");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            check1 = true;
                            if(comp.Deparments != null)
                            {
                                foreach (var item in comp.Deparments)
                                {
                                    if (item == null)
                                    {
                                        check1 = true;
                                        break;
                                    }
                                }
                                check1 = false;
                            }
                            if(check1)
                            {
                                do
                                {
                                    Console.WriteLine($"Enter The Index Of Department That Will Be Pushed from 1 to {Deps.Length} :- ");
                                    index = int.Parse(Console.ReadLine()) - 1;

                                    if (index + 1 > 0 && index + 1 <= Deps.Length)
                                    {
                                        if (Deps[index] != null)
                                        {
                                            Console.WriteLine("This Index Is Not Empty Try Another Index");
                                        }
                                        else check1 = false;
                                    }

                                } while (check1);
                                check1 = true;
                                Department dep1 = new Department();
                                #region Department
                                do
                                {
                                    Console.Write("Enter The Department ID :  ");
                                    dep1.DepID = int.Parse(Console.ReadLine());
                                    check1 = !IdChecker(Deps, dep1.DepID);
                                } while (check1);
                                check1 = true;
                                string DepName;
                                do
                                {
                                    Console.Write("Enter The Department Name :  ");
                                    DepName = Console.ReadLine();
                                    check1 = !DepNameChecker(Deps, DepName);
                                } while (check1);
                                check1 = true;
                                Manager mngr = new Manager();
                                #region Manager
                                Console.WriteLine("Fill Department Manager Data :-");
                                //Manager ID
                                do
                                {
                                    Console.WriteLine("Enter Manager ID :-");
                                    mngr.ManagerID = int.Parse(Console.ReadLine());
                                    if (mngr.ManagerID > 0)
                                    {
                                        check1 = false;
                                    }
                                } while (check1);
                                check1 = true;
                                //Manager Name
                                Console.WriteLine("Enter Manager Name :- ");
                                mngr.ManagerName = Console.ReadLine();
                                //Manager Salary
                                do
                                {
                                    Console.WriteLine("Enter Manager Salary Grater Than 20000 :- ");
                                    mngr.ManagerSalary = float.Parse(Console.ReadLine());
                                    if (mngr.ManagerSalary > 20000)
                                        check1 = false;
                                } while (check1);
                                #endregion
                                dep1.DepManager = mngr;
                                Empolyee[] Emplys;
                                int size = 0, indx = 0;
                                do
                                {
                                    Console.WriteLine("Enter Number Of Empolyee Inside :- ");
                                    size = int.Parse(Console.ReadLine());
                                } while (size <= 0);
                                Emplys = new Empolyee[size];
                                bool CheckerParam = false;
                                for (int i = 0; i < Emplys.Length; i++)
                                {
                                    Console.WriteLine($"Fill The Empolye Number {i + 1} Data :-");
                                    Empolyee em = new Empolyee();
                                    Console.WriteLine("Fill Data :-");
                                    bool check = false;
                                    do
                                    {
                                        Console.WriteLine("ID = ");
                                        em.ID = int.Parse(Console.ReadLine());
                                        check = IdChecker(Emplys, em.ID);
                                    } while (check == false);
                                    check = false;
                                    do
                                    {
                                        Console.WriteLine("Name = ");
                                        em.Name = Console.ReadLine();
                                        check = (em.Name.Length <= 2) ? false : true;
                                    } while (check == false);
                                    check = false;
                                    do
                                    {
                                        Console.WriteLine("Salary = ");
                                        em.Salary = float.Parse(Console.ReadLine());
                                        check = (em.Salary >= 5000 && em.Salary <= 20000) ? true : false;
                                    } while (check == false);
                                    int ClientSize = 0;
                                    do
                                    {
                                        Console.WriteLine("Enter Number Of Client For Empolyee :- ");
                                        ClientSize = int.Parse(Console.ReadLine());
                                    } while (ClientSize <= 0);
                                    Client[] Clients = new Client[ClientSize];
                                    for (int j = 0; j < Clients.Length; j++)
                                    {
                                        Clients[j] = new Client();
                                        Console.WriteLine($"Enter Client Numer {j + 1} :- ");
                                        int ClientIndx = 0;
                                        do
                                        {
                                            Console.WriteLine("Client_ID = ");
                                            ClientIndx = int.Parse(Console.ReadLine());
                                        } while (IdChecker(Clients, ClientIndx) == false);
                                        Clients[j].ID = ClientIndx;
                                        Console.WriteLine("Client_Name = ");
                                        Clients[j].Name = Console.ReadLine();
                                        Console.WriteLine("Client_Address = ");
                                        Clients[j].Address = Console.ReadLine();
                                    }
                                    em.Clients = Clients;
                                    Emplys[i] = em;
                                    Console.Clear();
                                    Console.WriteLine("New Empolyee Add Sucessfully :) ");
                                }
                                dep1.EmpolyeesArray = Emplys;
                                Deps[index] = new Department(dep1, DepName);
                                comp.Deparments = Deps;
                                #endregion
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine($"The Array Is Full it Has {comp.Deparments.Length} Of Size {count} !!");
                            }
                        }
                        break;
                    case 2:
                        comp.DisplayCompany();
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    
                }
            } while (option!=3);
            
        }
    }
}
