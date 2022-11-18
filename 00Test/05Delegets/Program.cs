Rechneroperation operation = new Rechneroperation(Addition);

int result1 = operation(4, 5);
Console.WriteLine(result1);

operation = /*new Rechneroperation(*/Subtration/*)*/; //Lange bzw Kurzeschreibweiße
int result = operation(4, 5);
Console.WriteLine(result);
Printer printer = PrintWithLeadingSpaces;
printer(77);
Console.WriteLine("------------------------------------");
printer = PrintWithLeading0;
printer(777);

Console.WriteLine("------------------------------------");
printer = PrintWithLeading0;

printer(99);
printer -= PrintWithLeading0;

if (printer != null) { printer(110); } // bei Aufruf eines delegets immer sicherstellen dass es nicht null ist

static int Addition(int x, int y)
{
    return x + y;   
}
static int Subtration(int x, int y)
{
    return x - y;
}
static void PrintWithLeadingSpaces(int x)
{
    Console.WriteLine("       " + x);
}
static void PrintWithLeading0(int x)
{
    Console.WriteLine("0000" + x);
}

public delegate int Rechneroperation(int x ,int y); //Definition eines Datentyps
                                                    //Mögliche werte: alle Funktionen oder Methoden
public delegate void Printer(int x);                //welche int als Rückgabewert habe und 2 int als Parameter