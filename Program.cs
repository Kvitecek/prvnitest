using System.ComponentModel.Design;

Console.WriteLine("Zadejte jméno");
string jmeno = Console.ReadLine();

if (jmeno == "Vita") 
{
    Console.WriteLine("je frajer");
}
else if(jmeno == "jakub")
{
    Console.WriteLine("je divnej")
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Neexistuje");
}

