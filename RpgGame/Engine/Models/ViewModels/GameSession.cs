using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Model;

namespace Engine.Models.ViewModels
{
    class GameSession
    {

        //#TODO: create a save system and load up here
        public Player currentPlayer { get; set; }

        public GameSession()
        {
            currentPlayer = new Player();

            //Asking for the user for name input for character name
            //Console.WriteLine("Hello adventurer, might i ask you name please?");

            currentPlayer.Name = "Default"; //Hardcoded
            currentPlayer.Gold = 1000;



        }



    }
}
