using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Engine.Model;
using Engine.Models;
using Engine.Factories;

namespace Engine.ViewModels
{
    public class GameSession
    {

        //#TODO: create a save system and up here
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation { get; set; }
        public World CurrentWorld { get; set; }

        //Event Subscription
        




        public GameSession()
        {
            CurrentPlayer = new Player
            {

                //Asking for the user for name input for character name
                //Console.WriteLine("Hello adventurer, might i ask you name please?");

                Name = "Default", //Hardcoded
                Strength = 1,
                Stamina = 1,
                Dexterity = 1,
                Intelligence = 1,
                Gold = 1000,
                Level = 1,
                Exp = 100
            };

            /*
            CurrentLocation = new Location
            {
                Name = "Istana",
                XCoordinate = 0,
                YCoordinate = -1,
                Description = "description test",
                ImageName = "des"
            };
             */



            //loading the locations to the (world)map
            WorldFactory factory = new WorldFactory();
            CurrentWorld = factory.CreateWorld();

            CurrentLocation = CurrentWorld.LocationAt(-1, 0);

            


        }



    }
}
