using LAB_ENCAPSULATION;

internal class Program
{
    private static void Main(string[] args)
    {
        /*        var lines = int.Parse(Console.ReadLine());
                var persons = new List<Person>();
                for (int i = 0; i < lines; i++)
                {
                    var cmdArgs = Console.ReadLine().Split();
                    var person = new Person(cmdArgs[0],
                                            cmdArgs[1],
                                            int.Parse(cmdArgs[2]),
                                            decimal.Parse(cmdArgs[3]));

                    persons.Add(person);
                }
                var bonus = decimal.Parse(Console.ReadLine());
                persons.ForEach(p => p.IncreaseSalary(bonus));
                persons.ForEach(p => Console.WriteLine(p.ToString()));*/
        Lab4();
    }

    static void Lab4()
    {
        var lines = int.Parse(Console.ReadLine());
        var persons = new List<Person>();
        for (int i = 0; i < lines; i++)
        {
            var cmdArgs = Console.ReadLine().Split();
            try
            {
                var person = new Person(cmdArgs[0],
                                        cmdArgs[1],
                                        int.Parse(cmdArgs[2]),
                                        decimal.Parse(cmdArgs[3]));

                persons.Add(person);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        Team team = new Team("SoftUni");
        foreach (var person in persons)
        {
            team.addPlayer(person);
        }
        Console.WriteLine($"First team has {team.FirstTeam.Count} players");
        Console.WriteLine($"Reserve team has {team.ReverseTeam.Count} players");
    }
}
