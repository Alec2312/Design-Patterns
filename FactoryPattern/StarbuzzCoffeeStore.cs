using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;

namespace SimpleFactory
{
    internal class StarbuzzCoffeeStore : CoffeeStore
    {
        public override Beverage CreateCoffee(string type, Size size)
        {
            switch (type.ToLower())
            {
                case "espresso":
                    Beverage espresso = new Espresso();
                    espresso.Size = size;
                    return espresso;

                case "doppio":
                    Beverage doppio = new Espresso();
                    doppio.Size = size;
                    doppio = new Espresso(doppio);
                    return doppio;

                case "lungo":
                    Beverage lungo = new Espresso();
                    lungo.Size = size;
                    lungo = new Water(lungo);
                    return lungo;

                case "macchiato":
                    Beverage macchiato = new Espresso();
                    macchiato.Size = size;
                    macchiato = new MilkFoam(macchiato);
                    return macchiato;

                case "corretta":
                    Beverage corretta = new Espresso();
                    corretta.Size = size;
                    corretta = new Liqour(corretta);
                    return corretta;

                case "conpanna":
                    Beverage conPanna = new Espresso();
                    conPanna.Size = size;
                    conPanna = new Whip(conPanna);
                    return conPanna;

                case "cappucinno":
                    Beverage cappucinno = new Espresso();
                    cappucinno.Size = size;
                    cappucinno = new SteamedMilk(cappucinno);
                    cappucinno = new MilkFoam(cappucinno);
                    return cappucinno;

                case "americano":
                    Beverage americano = new Espresso();
                    americano.Size = size;
                    americano = new Water(americano);
                    americano = new Water(americano);
                    return americano;

                case "caffelatte":
                    Beverage caffeLatte = new Espresso();
                    caffeLatte.Size = size;
                    caffeLatte = new SteamedMilk(caffeLatte);
                    caffeLatte = new SteamedMilk(caffeLatte);
                    caffeLatte = new MilkFoam(caffeLatte);
                    return caffeLatte;

                case "flatwhite":
                    Beverage flatWhite = new Espresso();
                    flatWhite.Size = size;
                    flatWhite = new SteamedMilk(flatWhite);
                    flatWhite = new SteamedMilk(flatWhite);
                    return flatWhite;

                case "romana":
                    Beverage romana = new Espresso();
                    romana.Size = size;
                    romana = new Lemon(romana);
                    return romana;

                case "morocchino":
                    Beverage morocchino = new Espresso();
                    morocchino.Size = size;
                    morocchino = new Chocolate(morocchino);
                    morocchino = new MilkFoam(morocchino);
                    return morocchino;

                case "mocha":
                    Beverage mocha = new Espresso();
                    mocha.Size = size;
                    mocha = new Chocolate(mocha);
                    mocha = new SteamedMilk(mocha);
                    mocha = new Whip(mocha);
                    return mocha;

                case "bicerin":
                    Beverage bicerin = new Espresso();
                    bicerin.Size = size;
                    bicerin = new BlackChocolate(bicerin);
                    bicerin = new WhiteChocolate(bicerin);
                    bicerin = new Whip(bicerin);
                    return bicerin;

                case "breve":
                    Beverage breve = new Espresso();
                    breve.Size = size;
                    breve = new MilkFoam(breve);
                    breve = new HalfMilk(breve);
                    return breve;

                case "rafcoffee":
                    Beverage rafCoffee = new Espresso();
                    rafCoffee.Size = size;
                    rafCoffee = new VanillaSugar(rafCoffee);
                    rafCoffee = new Cream(rafCoffee);
                    return rafCoffee;

                case "meadraf":
                    Beverage meadRaf = new Espresso();
                    meadRaf.Size = size;
                    meadRaf = new Honey(meadRaf);
                    meadRaf = new Cream(meadRaf);
                    return meadRaf;

                case "galao":
                    Beverage galao = new Espresso();
                    galao.Size = size;
                    galao = new MilkFoam(galao);
                    galao = new MilkFoam(galao);
                    return galao;

                case "caffeaffogato":
                    Beverage caffeAffogato = new Espresso();
                    caffeAffogato.Size = size;
                    caffeAffogato = new Espresso(caffeAffogato);
                    caffeAffogato = new IceCream(caffeAffogato);
                    return caffeAffogato;

                case "viennacoffee":
                    Beverage viennaCoffee = new Espresso();
                    viennaCoffee.Size = size;
                    viennaCoffee = new Espresso(viennaCoffee);
                    viennaCoffee = new Whip(viennaCoffee);
                    viennaCoffee = new Whip(viennaCoffee);
                    return viennaCoffee;

                case "glace":
                    Beverage glace = new Espresso();
                    glace.Size = size;
                    glace = new IceCream(glace);
                    return glace;

                case "chocolatemilk":
                    Beverage chocolateMilk = new Chocolate();
                    chocolateMilk.Size = size;
                    chocolateMilk = new Milk(chocolateMilk);
                    chocolateMilk = new Milk(chocolateMilk);
                    return chocolateMilk;

                case "demicreme":
                    Beverage demiCreme = new Espresso();
                    demiCreme.Size = size;
                    demiCreme = new Espresso(demiCreme);
                    demiCreme = new Cream(demiCreme);
                    demiCreme = new Cream(demiCreme);
                    return demiCreme;

                case "lattemacchiato":
                    Beverage latteMacchiato = new Espresso();
                    latteMacchiato.Size = size;
                    latteMacchiato = new SteamedMilk(latteMacchiato);
                    latteMacchiato = new SteamedMilk(latteMacchiato);
                    latteMacchiato = new MilkFoam(latteMacchiato);
                    return latteMacchiato;

                case "freddo":
                    Beverage freddo = new Espresso();
                    freddo.Size = size;
                    freddo = new Liqour(freddo);
                    freddo = new Ice(freddo);
                    return freddo;

                case "frappuccino":
                    Beverage frappuccino = new Espresso();
                    frappuccino.Size = size;
                    frappuccino = new Ice(frappuccino);
                    frappuccino = new SteamedMilk(frappuccino);
                    frappuccino = new Whip(frappuccino);
                    return frappuccino;

                case "caramelfrappuccino":
                    Beverage caramelFrappuccino = new Espresso();
                    caramelFrappuccino.Size = size;
                    caramelFrappuccino = new Ice(caramelFrappuccino);
                    caramelFrappuccino = new SteamedMilk(caramelFrappuccino);
                    caramelFrappuccino = new Cream(caramelFrappuccino);
                    caramelFrappuccino = new Syrup(caramelFrappuccino);
                    return caramelFrappuccino;

                case "frappe":
                    Beverage frappe = new Espresso();
                    frappe.Size = size;
                    frappe = new SteamedMilk(frappe);
                    frappe = new SteamedMilk(frappe);
                    frappe = new IceCream(frappe);
                    return frappe;

                case "irishcoffee":
                    Beverage irishCoffee = new Espresso();
                    irishCoffee.Size = size;
                    irishCoffee = new Espresso(irishCoffee);
                    irishCoffee = new Whiskey(irishCoffee);
                    irishCoffee = new Whip(irishCoffee);
                    return irishCoffee;
                default:
                    return null;
            }
        }
    }
}