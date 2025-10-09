using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class HomeTheaterFacade
    {
        private DvdPlayer dvdPlayer;
        private Projector projector;
        private Amplifier amplifier;
        private CdPlayer cdPlayer;
        private PopcornPopper popcornPopper;
        private Screen screen;
        private TheaterLights theaterLights;
        private Tuner tuner;

        public HomeTheaterFacade(DvdPlayer dvdPlayer, Projector projector, Amplifier amplifier, CdPlayer cdPlayer, PopcornPopper popcornPopper, Screen screen, TheaterLights theaterLights, Tuner tuner)
        {
            this.dvdPlayer = dvdPlayer;
            this.projector = projector;
            this.amplifier = amplifier;
            this.cdPlayer = cdPlayer;
            this.popcornPopper = popcornPopper;
            this.screen = screen;
            this.theaterLights = theaterLights;
            this.tuner = tuner;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("watch movie");

            popcornPopper.On();
            popcornPopper.Pop();

            theaterLights.Dim(10);
            screen.Down();

            projector.On();
            projector.SetInput(dvdPlayer);
            projector.WideScreenMode();

            amplifier.On();
            amplifier.SetDvd(dvdPlayer);
            amplifier.SetSurroundSound();
            amplifier.SetVolume(5);

            dvdPlayer.On();
            dvdPlayer.Play(movie);
        }

        public void EndMovie()
        {
            Console.WriteLine("end movie");

            dvdPlayer.Stop();
            dvdPlayer.Eject();
            dvdPlayer.Off();

            amplifier.Off();
            projector.Off();
            screen.Up();
            theaterLights.On();
            popcornPopper.Off();
        }

        public void ListenToCD()
        {
            Console.WriteLine("listen to cd");
            cdPlayer.On();
            amplifier.On();
            amplifier.SetCd(cdPlayer);
            amplifier.SetVolume(5);
            cdPlayer.Play();
        }

        public void EndCD()
        {
            Console.WriteLine("end cd");
            cdPlayer.Stop();
            cdPlayer.Off();
            amplifier.Off();
        }

        public void ListenToRadio()
        {
            Console.WriteLine("listen to radio");
            tuner.On();
            amplifier.On();
            amplifier.SetTuner(tuner);
            amplifier.SetVolume(5);
        }

        public void EndRadio()
        {
            Console.WriteLine("end radio");
            tuner.Off();
            amplifier.Off();
        }
    }
}
