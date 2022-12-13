List<string> mena = new List<string>();
mena.Add("Lionel Messi");
mena.Add("Cristiano Ronaldo");
mena.Add("Karim Benzema");
mena.Add("Neymar");
mena.Add("Erling Braut Haaland");
mena.Add("Kevin De Bruyne");
mena.Add("Theo Walcott");
Console.WriteLine("Zoznam futbalistov:\n");
foreach (string meno in mena)
    Console.WriteLine(meno);

mena.Sort();
Console.WriteLine("\nZoznam futbalistov, zoradenych podla mena:\n");

foreach (string meno in mena)
    Console.WriteLine(meno);