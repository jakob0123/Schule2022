Console.Write("Bitte eine Zahl eingeben:");
string input = Console.ReadLine();
//int inputValue = int.Parse(input); möglicherweiße wenn keine Zahl kommt einen Fehler
int number = 11;
bool success = int.TryParse(input, out number);
if (success)
{
    Console.WriteLine("Super du hast" + number + "eingegeben");
}
else
{
    //Eingabe wiederholen
    Console.WriteLine("Leider keine Zahl.");
}
//double.TryParse();
//bool.TryParse();

