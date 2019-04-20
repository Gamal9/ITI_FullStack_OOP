using System;

namespace DealingWithStructs
{
    class Program
    {
        public static bool IdChecker(Empolyee [] emps,int id)
        {
            if (id > emps.Length || id <= 0)
            {
                Console.WriteLine($"Wrong ID Try Again !! The ID Start From 1 And End With {emps.Length}");
                return false;
            }
            foreach (var item in emps)
            {
                if(item.ID == id)
                {
                    Console.WriteLine($"This ID Is Used Before !! The ID Start From 1 And End With {emps.Length}");
                    return false;
                }
            }
            return true;
        }

        public static bool IdChecker(Client[] Clients, int id)
        {
            if (id > Clients.Length|| id <= 0)
            {
                Console.WriteLine($"Wrong ID Try Again !! The ID Start From 1 And End With {Clients.Length}");
                return false;
            }
            foreach (var item in Clients)
            {
                if (item.ID == id)
                {
                    Console.WriteLine($"This ID Is Used Before !! The ID Start From 1 And End With {Clients.Length}");
                    return false;
                }
            }
            return true;            
        }

        public static bool AddressSearching(string key , Client[] client)
        {
            for (int j = 0; j < client.Length; j++)
            {
                if (client[j].Address == key)
                {
                    return true;
                }
            }
            return false;
        }

        static void Main(string[] args)
        {
            int i = 0;
            Empolyee[] Company;
            int size=0,indx=0;
            do
            {
                Console.WriteLine("Enter Number Of Empolyee Inside :- ");
                size = int.Parse(Console.ReadLine());
            } while (size<=0);
            Company = new Empolyee[size];
            do
            {
                Console.WriteLine("2- Insert Empolyee \n3- Display All \n4- Display Count Of Empolyee \n5- Customes Address Searching \n6- Exit");
                i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 2:
                        {
                            bool CheckerParam=false;
                            do
                            {
                                Console.WriteLine($"Enter The Index For Empolyee That Will Be Entered Start with 1 And End With {size} :- ");
                                indx = int.Parse(Console.ReadLine()) - 1;
                                if(indx<0)
                                {
                                    CheckerParam = false;
                                }
                                else if(indx>=size)
                                {
                                    CheckerParam = false;
                                }
                                else if(Company[indx].ID == 0)
                                {
                                    CheckerParam = true;
                                }
                                else if (Company[indx].ID != 0)
                                {
                                    Console.WriteLine("This Indesx Is Not Empty Try Another One !!");
                                    int counter = 0;
                                    foreach (var item in Company)
                                    {
                                        if(item.ID==0)
                                        {
                                            counter++;
                                        }
                                    }
                                    if(counter==0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("The Array Has Non Empty Places !!");
                                        CheckerParam = false;
                                        break;
                                    }
                                }
                                
                            } while (CheckerParam==false);
                            if(CheckerParam)
                            {
                                Empolyee em = new Empolyee();
                                Console.WriteLine("Fill Data :-");
                                bool check = false;
                                do
                                {
                                    Console.WriteLine("ID = ");
                                    em.ID = int.Parse(Console.ReadLine());
                                    check = IdChecker(Company, em.ID);
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
                                Company[indx] = em;
                                Console.Clear();
                                Console.WriteLine("New Empolyee Add Sucessfully :) ");
                            }
                        }
                        break;
                    case 3:
                        {
                            Console.Clear();
                            int EmptyArrayChecker = 0;
                            for (int k = 0; k < Company.Length; k++)
                            {
                                if (Company[k].ID == 0)
                                {
                                    EmptyArrayChecker++;
                                }
                                else
                                {
                                    Company[k].DisplayAll();
                                }
                            }
                            if (EmptyArrayChecker == Company.Length)
                            {
                                Console.WriteLine("Empty List !! \n");
                            }
                        }
                        break;
                    case 4:
                        {
                            Console.Clear();
                            int Length=0;
                            foreach (var item in Company)
                            {
                                if (item.ID != 0)
                                {
                                    Length++;
                                }
                            }
                            Console.WriteLine($"The Length Of Un Empty Values Are => {Length} From Size {Company.Length}");
                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine("Enter The Address Keyword That You want Searching Inside Company Empolyees :-");
                            string address = Console.ReadLine();
                            bool Found = false;
                            Console.Clear();
                            foreach (var item in Company)
                            {
                                if (item.Clients == null)
                                {
                                    Found = false;
                                }
                                if (AddressSearching(address, item.Clients))
                                {
                                    Console.WriteLine($"The Address Is Belongs To {item.Name} Clients \n");
                                    Found = true;
                                }
                            }
                            if(Found==false)
                            {
                                Console.Clear();
                                Console.WriteLine($"This Address [{address}] Is Not Fount Inside Any Of Compang Empolyees !!");
                            }
                        }
                        break;
                    case 6:
                        Console.Clear();
                        break;
                }
            } while (i!=6);

            
            
        }
    }
}
