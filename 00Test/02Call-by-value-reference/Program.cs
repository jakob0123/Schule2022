using _02Call_by_value_reference;

void SwapD(double a, double b)
{
    double temp = a;
    a = b;
    b  = temp;
}

void SwapDref(ref double a, ref double b)
{
    double temp = a;
    a = b;
    b = temp;
}
void SwapNameref(Student a,Student b)
{
    Student temp = a;
    a = b;
    b = temp;
}
void SwapNameref1(ref Student a, ref Student b)
{
    Student temp = a;
    a = b;
    b = temp;
    a.Firstname = "DR." + a.Firstname; //Änderungen am Objekt selbst sind natürlich nach außen hin sichtbar
}
void generatNumber(out int number)
{
    number = 100;
}
void generateNumbers(out int a, out int b)
{
    a = 100;
    b = 200;
}
void generateNumbersArray(out int[] numbers)
{
    numbers = new int[3];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = i * 2;
    }
}
double a = 5.0;
double b = 3.5;

SwapD(a, b);// call-by-value

Console.WriteLine("a: " + a);
Console.WriteLine("b: "+b);



SwapDref(ref a,ref b);// call-by-reference

Console.WriteLine("a: " + a);
Console.WriteLine("b: " + b);

Student elias = new Student()
{
    Firstname = "Elias",
    Lastname = "Seeböck"
};
Student tobias = new Student()
{
    Firstname = "Tobias",
    Lastname = "Zarzer"
};
SwapNameref(elias, tobias); //call-by-value
Console.WriteLine("Elias: "+elias);
Console.WriteLine("Tobias: "+tobias);

SwapNameref1(ref elias, ref tobias); //call-by-reference
Console.WriteLine("Elias: " + elias);
Console.WriteLine("Tobias: " + tobias);

int i;
//Console.WriteLine(i); an dieser Stelle kann die Variable nicht verwendet werden
generatNumber(out i);
int[] mynumbers;
generateNumbersArray(out mynumbers);
Console.WriteLine(i);//erst hier ist der Wert da
for (int j = 0; j < mynumbers.Length; j++)
{
    Console.WriteLine(j);
}




