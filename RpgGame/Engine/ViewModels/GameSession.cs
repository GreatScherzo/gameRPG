using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Engine.Model;
using Engine.Models;

namespace Engine.ViewModels
{
    public class GameSession
    {

        //#TODO: create a save system and load up here
        public Player currentPlayer { get; set; }
        public Location currentLocation { get; set; }

        //Event Subscription
        




        public GameSession()
        {
            currentPlayer = new Player();

            //Asking for the user for name input for character name
            //Console.WriteLine("Hello adventurer, might i ask you name please?");

            currentPlayer.Name = "Default"; //Hardcoded
            currentPlayer.Strength = 1;
            currentPlayer.Stamina = 1;
            currentPlayer.Dexterity = 1;
            currentPlayer.Intelligence = 1;
            currentPlayer.Gold = 1000;
            currentPlayer.Level = 1;
            currentPlayer.Exp = 100;



            currentLocation = new Location();
            currentLocation.Name = "Istana";
            currentLocation.XCoordinate = 0;
            currentLocation.YCoordinate = 0;
            currentLocation.Description = "The Istana";


            



        }



    }
}
