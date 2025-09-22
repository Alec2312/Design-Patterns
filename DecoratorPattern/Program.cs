using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Beverage espresso = new Espresso();
            espresso.Size = Size.VENDI;
            PrintBeverage(espresso);

            Beverage doppio = new Espresso();
            doppio.Size = Size.GRANDE;
            doppio = new Espresso(doppio);
            PrintBeverage(doppio);

            Beverage lungo = new Espresso();
            lungo.Size = Size.VENDI;
            lungo = new Water(lungo);
            PrintBeverage(lungo);

            Beverage macchiato = new Espresso();
            macchiato.Size = Size.TALL;
            macchiato = new MilkFoam(macchiato);
            PrintBeverage(macchiato);

            Beverage corretta = new Espresso();
            corretta.Size = Size.VENDI;
            corretta = new Liqour(corretta);
            PrintBeverage(corretta);

            Beverage conPanna = new Espresso();
            conPanna.Size = Size.VENDI;
            conPanna = new Whip(conPanna);
            PrintBeverage(conPanna);

            Beverage cappucinno = new Espresso();
            cappucinno.Size = Size.GRANDE;
            cappucinno = new SteamedMilk(cappucinno);
            cappucinno = new MilkFoam(cappucinno);
            PrintBeverage(cappucinno);

            Beverage americano = new Espresso();
            americano.Size = Size.GRANDE;
            americano = new Water(americano);
            americano = new Water(americano);
            PrintBeverage(americano);

            Beverage caffeLatte = new Espresso();
            caffeLatte.Size = Size.TALL;
            caffeLatte = new SteamedMilk(caffeLatte);
            caffeLatte = new SteamedMilk(caffeLatte);
            caffeLatte = new MilkFoam(caffeLatte);
            PrintBeverage(caffeLatte);

            Beverage flatWhite = new Espresso();
            flatWhite.Size = Size.GRANDE;
            flatWhite = new SteamedMilk(flatWhite);
            flatWhite = new SteamedMilk(flatWhite);
            PrintBeverage(flatWhite);

            Beverage romana = new Espresso();
            romana.Size = Size.GRANDE;
            romana = new Lemon(romana);
            PrintBeverage(romana);

            Beverage morocchino = new Espresso();
            morocchino.Size = Size.GRANDE;
            morocchino = new Chocolate(morocchino);
            morocchino = new MilkFoam(morocchino);
            PrintBeverage(morocchino);

            Beverage mocha = new Espresso();
            mocha.Size = Size.TALL;
            mocha = new Chocolate(mocha);
            mocha = new SteamedMilk(mocha);
            mocha = new Whip(mocha);
            PrintBeverage(mocha);

            Beverage bicerin = new Espresso();
            bicerin.Size = Size.GRANDE;
            bicerin = new BlackChocolate(bicerin);
            bicerin = new WhiteChocolate(bicerin);
            bicerin = new Whip(bicerin);
            PrintBeverage(bicerin);

            Beverage breve = new Espresso();
            breve.Size = Size.GRANDE;
            breve = new MilkFoam(breve);
            breve = new HalfMilk(breve);
            PrintBeverage(breve);

            Beverage rafCoffee = new Espresso();
            rafCoffee.Size = Size.TALL;
            rafCoffee = new VanillaSugar(rafCoffee);
            rafCoffee = new Cream(rafCoffee);
            PrintBeverage(rafCoffee);

            Beverage meadRaf = new Espresso();
            meadRaf.Size = Size.GRANDE;
            meadRaf = new Honey(meadRaf);
            meadRaf = new Cream(meadRaf);
            PrintBeverage(meadRaf);

            Beverage galao = new Espresso();
            galao.Size = Size.GRANDE;
            galao = new MilkFoam(galao);
            galao = new MilkFoam(galao);
            PrintBeverage(galao);

            Beverage caffeAffogato = new Espresso();
            caffeAffogato.Size = Size.TALL;
            caffeAffogato = new Espresso(caffeAffogato);
            caffeAffogato = new IceCream(caffeAffogato);
            PrintBeverage(caffeAffogato);

            Beverage viennaCoffee = new Espresso();
            viennaCoffee.Size = Size.GRANDE;
            viennaCoffee = new Espresso(viennaCoffee);
            viennaCoffee = new Whip(viennaCoffee);
            viennaCoffee = new Whip(viennaCoffee);
            PrintBeverage(viennaCoffee);

            Beverage glace = new Espresso();
            glace.Size = Size.GRANDE;
            glace = new IceCream(glace);
            PrintBeverage(glace);

            Beverage chocolateMilk = new Chocolate();
            chocolateMilk.Size = Size.GRANDE;
            chocolateMilk = new Milk(chocolateMilk);
            chocolateMilk = new Milk(chocolateMilk);
            PrintBeverage(chocolateMilk);

            Beverage demiCreme = new Espresso();
            demiCreme.Size = Size.GRANDE;
            demiCreme = new Espresso(demiCreme);
            demiCreme = new Cream(demiCreme);
            demiCreme = new Cream(demiCreme);
            PrintBeverage(demiCreme);

            Beverage latteMacchiato = new Espresso();
            latteMacchiato.Size = Size.TALL;
            latteMacchiato = new SteamedMilk(latteMacchiato);
            latteMacchiato = new SteamedMilk(latteMacchiato);
            latteMacchiato = new MilkFoam(latteMacchiato);
            PrintBeverage(latteMacchiato);

            Beverage freddo = new Espresso();
            freddo.Size = Size.GRANDE;
            freddo = new Liqour(freddo);
            freddo = new Ice(freddo);
            PrintBeverage(freddo);

            Beverage frappuccino = new Espresso();
            frappuccino.Size = Size.GRANDE;
            frappuccino = new Ice(frappuccino);
            frappuccino = new SteamedMilk(frappuccino);
            frappuccino = new Whip(frappuccino);
            PrintBeverage(frappuccino);

            Beverage caramelFrappuccino = new Espresso();
            caramelFrappuccino.Size = Size.TALL;
            caramelFrappuccino = new Ice(caramelFrappuccino);
            caramelFrappuccino = new SteamedMilk(caramelFrappuccino);
            caramelFrappuccino = new Cream(caramelFrappuccino);
            caramelFrappuccino = new Syrup(caramelFrappuccino);
            PrintBeverage(caramelFrappuccino);

            Beverage frappe = new Espresso();
            frappe.Size = Size.GRANDE;
            frappe = new SteamedMilk(frappe);
            frappe = new SteamedMilk(frappe);
            frappe = new IceCream(frappe);
            PrintBeverage(frappe);

            Beverage irishCoffee = new Espresso();
            irishCoffee.Size = Size.VENDI;
            irishCoffee = new Espresso(irishCoffee);
            irishCoffee = new Whiskey(irishCoffee);
            irishCoffee = new Whip(irishCoffee);
            PrintBeverage(irishCoffee);

            Console.ReadLine();
        }

        static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine(beverage.GetDescription() + " $" + beverage.cost().ToString("#.##"));
        }
    }
}