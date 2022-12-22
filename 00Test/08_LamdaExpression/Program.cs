Action printHelloWorld = () => Console.WriteLine("Hello World");            //Delegate des typs action mit einer ´zugewiesenen Lambda Expression

Func<int,int,int> add = (x, y) => x + y;
//Func<int, int, int> add = (x, y) => { return x + y; };          //gleiche Bedeutung wie zeile oben

Func<string,string,string> concat = (s1, s2) => s1 + " " + s2;

Action<int> incrementAndPrint = x =>
{
    x++;
    Console.WriteLine(x);
};


printHelloWorld();          //Aufruf eines delegates --> keine Methode
Console.WriteLine(add(4,5));
Console.WriteLine(concat("alex","stranz"));
incrementAndPrint(100);