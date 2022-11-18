using _06Events;

Persons jakob = new Persons()
{
    Name = "Jakob Prem"
};
Persons florian = new Persons()
{
    Name = "Florian Winkler"
};
Bar excalibur = new Bar() { Name = "Excalibur" };
jakob.enter(excalibur);
florian.enter(excalibur);

excalibur.SpendRound();
Persons tobias = new Persons()
{
    Name = "Tobias Zarzer"
};
tobias.enter(excalibur);

excalibur.SpendRound();
jakob.leave(excalibur);
excalibur.SpendRound();

ExtentedBar moon = new ExtentedBar() { Name = "Moon" };

jakob.enter(moon);
florian.enter(moon);
tobias.enter(moon);

moon.SpendNonAlcoholicDrink();
moon.SpendAlcoholicDrink();