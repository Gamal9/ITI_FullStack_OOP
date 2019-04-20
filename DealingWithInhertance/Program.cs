using System;

namespace DealingWithInhertance
{
    class Program
    {

        public static void DisplayTeamData(TeamModel team)
        {
            Console.WriteLine($"Team Name Is : {team.Name}\n\t Coach Data Is : {team.TeamCoach.DisplayPlayer()}\n\t\t Team Has 11 Player Are :-\n\t\t\t");
            foreach (var item in team.Players)
            {
                if(item.GetType()==typeof(Striker))
                {
                    Console.WriteLine(((Striker)item).DisplayPlayer());
                }
                if (item.GetType() == typeof(Defender))
                {
                    Console.WriteLine(((Defender)item).DisplayPlayer());
                }
                if (item.GetType() == typeof(GoalKeeper))
                {
                    Console.WriteLine(((GoalKeeper)item).DisplayPlayer());
                }
            }
        }


        static void Main(string[] args)
        {
            TeamModel Team = new TeamModel();
            bool checker = true;
            do
            {
                Console.Write("Enter Team ID : ");
                Team.TeamID = int.Parse(Console.ReadLine());
                if(Team.TeamID>0)
                {
                    checker = false;
                }
            } while (checker);
            Console.Write("Team Name: ");
            Team.Name = Console.ReadLine();
            Console.WriteLine("Coach Data :-");
            checker = true;
            int id;
            do
            {
                Console.Write("Enter Coach ID : ");
                id = int.Parse(Console.ReadLine());
                if (id > 0)
                {
                    checker = false;
                }
            } while (checker);
            Console.Write("Coach Name: ");
            string name = Console.ReadLine();
            int CrCount;
            checker = true;
            do
            {
                Console.Write("Coach Creaw Count : ");
                CrCount = int.Parse(Console.ReadLine());
                if (id > 0)
                {
                    checker = false;
                }
            } while (checker);
            Team.TeamCoach = new Coach(id, name, CrCount);
            object[] players =
                {
                new GoalKeeper(1,"Ahmed GoalKeeper",9,75,88) ,
                new Defender(1,"Ahmed Defender",9,75,88) ,
                new Defender(1,"Ahmed Defender",9,75,88) ,
                new Defender(1,"Ahmed Defender",9,75,88) ,
                new Defender(1,"Ahmed Defender",9,75,88) ,
                new Striker(1,"Ahmed Striker",9,75,88) ,
                new Striker(1,"Ahmed Striker",9,75,88) ,
                new Striker(1,"Ahmed Striker",9,75,88) ,
                new Striker(1,"Ahmed Striker",9,75,88) ,
                new Striker(1,"Ahmed Striker",9,75,88) ,
                new Striker(1,"Ahmed Striker",9,75,88) ,
            };
            Team.Players = players;
            DisplayTeamData(Team);


            Console.ReadKey();
        }
    }
}
