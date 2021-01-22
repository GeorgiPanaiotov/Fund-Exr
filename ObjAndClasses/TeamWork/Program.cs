using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            Teams[] teams = new Teams[n];


            for (int i = 0; i < n; i++)
            {

                teams[i] = new Teams();
                string[] users = Console.ReadLine().Split('-', StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int j = 0; j < teams.Length; j++)
                {
                    if (teams[j].Team == users[1])
                    {
                        Console.WriteLine($"Team {users[1]} was already created!");
                        break;
                    }
                    else
                    {
                        if (!teams[j].Users.Contains(users[0]))
                        {
                            Console.WriteLine($"Team {users[1]} has been created by {users[0]}!");
                            teams[i] = new Teams(users[1], users[0]);
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"{users[0]} cannot create another team!");
                            break;
                        }
                    }
                }

            }

            string[] input = Console.ReadLine().Split("->", StringSplitOptions.RemoveEmptyEntries).ToArray();

            while (input[0] != "end of assignment")
            {
                for (int i = 0; i < teams.Length; i++)
                {
                    if (teams[i].Team.Contains(input[1]))
                    {
                        if (teams[i].Users.Contains(input[0]))
                        {
                            Console.WriteLine($"Member {input[0]} cannot join team {input[1]}!");
                            break;
                        }
                        else
                        {
                            teams[i].Users.Add(input[0]);
                            break;
                        }
                    }
                    if (i == teams.Length - 1 && !(teams[i].Team.Contains(input[1])))
                    {
                        Console.WriteLine($"Team {input[1]} does not exist!");
                        break;
                    }

                }
                input = Console.ReadLine().Split("->", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }


            List<string> disbanded = new List<string>();
            List<Teams> teamsLeft = new List<Teams>();
            
                for (int j = 0; j < teams.Length; j++)
                {
                    if (teams[j].Users.Count <= 1)
                    {
                        disbanded.Add(teams[j].Team);
                    }
                    else
                    {
                        teamsLeft.Add(teams[j]);
                    }

                }
            

            teamsLeft = teamsLeft.OrderByDescending(x => x.Team).ToList();
            disbanded = disbanded.OrderByDescending(x => x).ToList();

            for (int i = 0; i < teamsLeft.Count; i++)
            {
                Console.WriteLine(teamsLeft[i].Team);
                for (int j = 0; j < teamsLeft[i].Users.Count; j++)
                {
                    if (j == 0)
                    {
                        Console.WriteLine("- " + teamsLeft[i].Users[0]);

                    }
                    else
                    {
                        Console.WriteLine("-- " + teamsLeft[i].Users[j]);
                    }
                }
            }

            Console.WriteLine("Teams to disband:");
            for (int i = 0; i < disbanded.Count; i++)
            {
                Console.WriteLine(disbanded[i]);
            }

        }
    }
    public class Teams
    {
        public Teams()
        {
            Team = string.Empty;
            Users = new List<string>();
        }
        public Teams(string team, string user)
        {
            this.Team = team;
            this.Users = new List<string>() { user };
        }
        public string Team { get; set; }
        public List<string> Users { get; set; }
    }
}
