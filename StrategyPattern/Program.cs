using StrategyPattern.Ducks;
using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;
using StrategyPattern.Interfaces.SwimBehavior;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck mallardDuck = new MallardDuck();
            Duck redheadDuck = new RedheadDuck();
            Duck decoyDuck = new DecoyDuck();
            Duck rubberDuck = new RubberDuck();
            Duck robotDuck = new RobotDuck();

            mallardDuck.Display();
            mallardDuck.setFlyBehavior(new FlyWithWings());
            mallardDuck.setQuackBehavior(new RegularQuack());
            mallardDuck.setSwimBehavior(new Float());
            mallardDuck.PerformFly();
            mallardDuck.PerformQuack();
            mallardDuck.PerformSwim();
            Console.WriteLine("");

            redheadDuck.Display();
            redheadDuck.setFlyBehavior(new FlyWithWings());
            redheadDuck.setQuackBehavior(new RegularQuack());
            redheadDuck.setSwimBehavior(new Float());
            redheadDuck.PerformFly();
            redheadDuck.PerformQuack();
            redheadDuck.PerformSwim();
            Console.WriteLine("");

            decoyDuck.Display();
            decoyDuck.setFlyBehavior(new FlyNoWay());
            decoyDuck.setQuackBehavior(new MuteQuack());
            decoyDuck.setSwimBehavior(new Float());
            decoyDuck.PerformFly();
            decoyDuck.PerformQuack();
            decoyDuck.PerformSwim();
            Console.WriteLine("");

            rubberDuck.Display();
            rubberDuck.setFlyBehavior(new FlyNoWay());
            rubberDuck.setQuackBehavior(new Squeak());
            rubberDuck.setSwimBehavior(new Float());
            rubberDuck.PerformFly();
            rubberDuck.PerformQuack();
            rubberDuck.PerformSwim();
            Console.WriteLine("");

            robotDuck.Display();
            robotDuck.setFlyBehavior(new FlyWithRocket());
            robotDuck.setQuackBehavior(new MuteQuack());
            robotDuck.setSwimBehavior(new Sink());
            robotDuck.PerformFly();
            robotDuck.PerformQuack();
            robotDuck.PerformSwim();
            Console.ReadLine();
        }
    }
}