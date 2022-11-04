int i = 100;
int? j = null;    
// not nullable noch kein Wert zugwiesen
Console.WriteLine(j);

j = 200;
Console.WriteLine(j);

if (j.HasValue)
{
    i = i * j.Value;
}


