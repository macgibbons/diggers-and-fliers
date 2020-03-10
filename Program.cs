using System;
using System.Collections.Generic;

namespace diggers_and_fliers
{
    class Program
    {
        static void Main (string[] args)
        {
            var ant = new Ant ();
            var copperhead = new Copperhead ();
            var betta = new BettaFish ();
            var earthworm = new Earthwoorm ();
            var finch = new Finch ();
            var gerbil = new Gerbil ();
            var mouse = new Mouse ();
            var parakeet = new Parakeet ();
            var rattlesnake = new Rattlesnake ();
            var terrapin = new Terrapin ();

            var Diggers = new DiggerCOntainer ();
            var Fliers = new FlyerCOntainer ();
            var Swimers = new SwimmerCOntainer ();
            var Walkers = new WalkerCOntainer ();

            Diggers.Diggers.Add (ant);
            Diggers.Diggers.Add (earthworm);
            Fliers.Fliers.Add (finch);
            Fliers.Fliers.Add (parakeet);
            Swimers.Swimmers.Add (betta);
            Swimers.Swimmers.Add (terrapin);
            Walkers.Walkers.Add (copperhead);
            Walkers.Walkers.Add (gerbil);
            Walkers.Walkers.Add (mouse);
            Walkers.Walkers.Add (rattlesnake);
            Console.WriteLine ("DIGGERS");
            foreach (var digger in Diggers.Diggers)
            {
                digger.Dig ();
            }
            Console.WriteLine ("FLIERS");
            foreach (var flyer in Fliers.Fliers)
            {
                flyer.Fly ();
            }
            Console.WriteLine ("WALKERS");
            foreach (var walker in Walkers.Walkers)
            {
                walker.Walk ();
            }
            Console.WriteLine ("SWIMMERS");
            foreach (var swimmer in Swimers.Swimmers)
            {
                swimmer.Swim ();
            }
        }
    }
}