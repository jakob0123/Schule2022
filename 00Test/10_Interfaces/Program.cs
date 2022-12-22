using _10_Interfaces;

Coffee espresso = new Coffee("Espresso");
IHotDrink icedCoffee = new Coffee("Iced Coffee");
IHotDrink wine = new HotSpicedWine();

List<IHotDrink> drinks = new List<IHotDrink>();
drinks.Add(icedCoffee);
drinks.Add(wine);
drinks.Add(espresso);

foreach (var drink in drinks)
{
    drink.cool();
    Console.WriteLine(drink.Degree);
}