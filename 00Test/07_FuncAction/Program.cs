Func<int,int,int> operation = new Func<int, int, int>(addition);          // generische Func ersetzt "Rechenoperation"
int result = operation(4, 5);
Console.WriteLine($"Result: {result}");

operation = subtraction;                // kurze Schreibweise
result = operation(4, 5);
Console.WriteLine($"Result: {result}");

Action<int> printer = printWithLeadinSpaces;        //Generische Action ersetzt "Printer"
printer(77);    
Console.WriteLine("----------------------");
printer += printWithLeading0;
printer(88);
Console.WriteLine("----------------------");
printer -= printWithLeadinSpaces;
printer(99);
printer -= printWithLeading0;
if (printer != null)
{
    printer(110);                                          // Bei aufruf eines delegates, immer sicherstellen, dass es nicht null ist
}
void printWithLeadinSpaces(int x)
{
    Console.WriteLine("         " + x);
}

static void printWithLeading0(int x)
{
    Console.WriteLine("000000000" + x);
}
static int addition(int x, int y)
{
    return x + y;
}
static int subtraction(int x, int y)
{
    return x - y;
}
