namespace FacadePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Amplifier amp = new Amplifier();
            CdPlayer cdPlayer = new CdPlayer(amp);
            DvdPlayer dvdPlayer = new DvdPlayer(amp);
            PopcornPopper popcornPopper = new PopcornPopper();
            Projector projector = new Projector();
            Screen screen = new Screen();
            TheaterLights lights = new TheaterLights();
            Tuner tuner = new Tuner(amp);

            HomeTheaterFacade homeTheater = new HomeTheaterFacade(
                dvdPlayer, projector, amp, cdPlayer, popcornPopper, screen, lights, tuner
            );

            homeTheater.WatchMovie("Die Hard");
            homeTheater.EndMovie();
            homeTheater.ListenToCD();
            homeTheater.EndCD();
            homeTheater.ListenToRadio();
            homeTheater.EndRadio();

            Console.ReadLine();
        }
    }
}