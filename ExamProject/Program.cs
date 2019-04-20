using System;

namespace ExamProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students ={
                new Student{StudentID=1,Name="Ahmed"},
                new Student{StudentID=2,Name="Ali"},
                new Student{StudentID=3,Name="Ibrahim"},
                new Student{StudentID=4,Name="Moahmed"},
                new Student{StudentID=5,Name="Mostafa"},
            };
            bool check = true;
            int typ;
            Exam exm = new Exam();
            exm.ExamName = "Full Stack";
            do
            {
                Console.WriteLine("Choose Your Type : \n1-Teacher \n2-Student \n3- Exit");
                typ = int.Parse(Console.ReadLine());
                bool ch = true;
                switch (typ)
                {
                    case 1:
                        {
                            exm.Students = students;
                            do
                            {
                                Console.WriteLine("1-Add Exam \n2-Browse Students Degree");
                                int choose = int.Parse(Console.ReadLine());
                                if (choose > 0 && choose < 3)
                                {
                                    switch (choose)
                                    {
                                        case 1:
                                            {
                                                do
                                                {
                                                    Console.WriteLine("Enter Exam ID :-");
                                                    exm.ExamID = int.Parse(Console.ReadLine());
                                                } while (exm.ExamID <= 0);
                                                exm.Students = students;
                                                int size = 0;
                                                do
                                                {
                                                    Console.WriteLine("Enter Questions Count/Length :-");
                                                    size = int.Parse(Console.ReadLine());
                                                    exm.Questions = new Question[size];
                                                } while (size <= 0);
                                                for (int i = 0; i < size; i++)
                                                {
                                                    int Qtype = 0;
                                                    do
                                                    {
                                                        Console.WriteLine($"Enter The Question number {i + 1} Type :- \n[1- True Or False Question] [2- MCQ Question]");
                                                        Qtype = int.Parse(Console.ReadLine());
                                                    } while (Qtype <= 0 && Qtype>2);
                                                    switch (Qtype)
                                                    {
                                                        case 1:
                                                            {
                                                                exm.Questions[i] = new TFQuestion();
                                                                exm.Questions[i].QuestionID = i + 1;
                                                                exm.Questions[i].Qbody = new string[] {"True","False" };
                                                                int Qdegree = 0;
                                                                do
                                                                {
                                                                    Console.Write($"Question {i + 1} Degrees Should Be Greater Than 0 :-");
                                                                    Qdegree = int.Parse(Console.ReadLine());
                                                                } while (Qdegree <= 0);
                                                                Console.Write("Enter The Question :- ");
                                                                exm.Questions[i].QTitle = Console.ReadLine();
                                                                do
                                                                {
                                                                    Console.WriteLine("The True Result Index is : [Choose 1-If False] [Choose 2-If True]");
                                                                    exm.Questions[i].ResultIndex = int.Parse(Console.ReadLine())-1;
                                                                } while (exm.Questions[i].ResultIndex < 0 && exm.Questions[i].ResultIndex > 2);
                                                            }
                                                            Console.WriteLine("Question Added Sucessfully");
                                                            break;
                                                        case 2:
                                                            {
                                                                {
                                                                    exm.Questions[i] = new MCQuestion();
                                                                    exm.Questions[i].QuestionID = i + 1;
                                                                    int Qdegree = 0;
                                                                    do
                                                                    {
                                                                        Console.Write($"Question {i + 1} Degrees Should Be Greater Than 0 :-");
                                                                        Qdegree = int.Parse(Console.ReadLine());
                                                                    } while (Qdegree <= 0);
                                                                    Console.Write("Enter The Question :- ");
                                                                    exm.Questions[i].QTitle = Console.ReadLine();
                                                                    int Qtysize = 0;
                                                                    do
                                                                    {
                                                                        Console.Write("Entry How Many Selections For This Question : ");
                                                                        Qtysize = int.Parse(Console.ReadLine());
                                                                    } while (Qtysize <= 0);

                                                                    exm.Questions[i].Qbody = new string[Qtysize];
                                                                    Console.WriteLine("Enter The Shown Selections :-");
                                                                    for (int j = 0; j < Qtysize; j++)
                                                                    {
                                                                        Console.WriteLine($"Selection Number {j + 1} : ");
                                                                        exm.Questions[i].Qbody[j] = Console.ReadLine();
                                                                        Console.WriteLine("\n");
                                                                    }
                                                                    do
                                                                    {
                                                                        Console.Write("The True Result Index is : ");
                                                                        for (int k = 0; k < Qtysize; k++)
                                                                        {
                                                                            Console.Write($"Choose {k + 1} if [{exm.Questions[i].Qbody[k]}]\t");
                                                                        }
                                                                        do
                                                                        {
                                                                            exm.Questions[i].ResultIndex = int.Parse(Console.ReadLine())-1;
                                                                        } while (exm.Questions[i].ResultIndex < 0 && exm.Questions[i].ResultIndex >2);
                                                                        exm.Questions[i] = exm.Questions[i];
                                                                        Console.Clear();
                                                                        Console.WriteLine("Question Added Sucessfully");
                                                                    } while (exm.Questions[i].ResultIndex <= 0 && exm.Questions[i].ResultIndex > 2);
                                                                }
                                                            }
                                                            break;
                                                        default:
                                                            break;
                                                    }
                                                }
                                                Console.WriteLine("Exam Added Sucessfully");
                                            }
                                            break;
                                        case 2:
                                            {
                                                Console.Clear();
                                                foreach (var item in exm.Students)
                                                {
                                                    item.DisplayStudent();
                                                }
                                            }
                                            break;
                                    }
                                    ch = false;
                                }

                            } while (ch);

                        }
                        break;
                    case 2:
                        {
                            if (exm.Students != null)
                            {
                                Student std = new Student();
                                int id = 0;
                                do
                                {
                                    Console.Write("Enter You ID : ");
                                    id = int.Parse(Console.ReadLine());
                                    foreach (var item in exm.Students)
                                    {
                                        if (id == item.StudentID)
                                        {
                                            int ExType = 0;
                                            do
                                            {
                                                Console.WriteLine("Choose The Exam Type : \n1-Partice Exam \n2-Final Exam");
                                                ExType = int.Parse(Console.ReadLine());
                                            } while (ExType <= 0 && ExType > 2);
                                            Console.WriteLine($"Exam ID :{exm.ExamID} Exam Name :{exm.ExamName}");
                                            switch (ExType)
                                            {
                                                case 1:
                                                    {
                                                        for (int i = 0; i < exm.Questions.Length; i++)
                                                        {
                                                            Console.WriteLine($"Question {i + 1} : {exm.Questions[i].QTitle}");
                                                            Console.WriteLine($"Answer : {exm.Questions[i].Result()}");
                                                        }
                                                    }
                                                    break;
                                                case 2:
                                                    {
                                                        for (int i = 0; i < exm.Questions.Length; i++)
                                                        {
                                                            Console.WriteLine($"Question {i + 1} : {exm.Questions[i].QTitle}");
                                                            Console.Write("Choose The Correct Answer:");
                                                            int answer = 0;
                                                            for (int j = 0; j < exm.Questions[i].Qbody.Length; j++)
                                                            {
                                                                Console.WriteLine($"[{j + 1}-{exm.Questions[i].Qbody[j]}    ");
                                                            }
                                                            do
                                                            {
                                                                Console.Write("Enter Your Answer : ");
                                                                answer = int.Parse(Console.ReadLine())-1;
                                                            } while (answer < 0);
                                                            std.StudentDegree += (exm.Questions[i].IsTrue(answer)) ? exm.Questions[i].QuestionDegree : 0;
                                                        }
                                                        Console.WriteLine($"Student Final Degrees = {std.StudentDegree}");  
                                                    }
                                                    break;
                                            }
                                            break;
                                        }
                                        else id = 0;                                    }
                                    if (id == 0)
                                    {
                                        Console.WriteLine("This ID Not Belongs To Any Of Students .. Try Another One !!");
                                    }
                                } while (id <= 0);
                                
                            }
                            else
                            {
                                Console.WriteLine("There Is No Exam !!");
                            }
                        }
                        break;
                    case 3:
                        check = false;
                        break;
                }
            } while (check);


            Console.WriteLine(exm);
            Console.ReadKey();
        }
    }
}
