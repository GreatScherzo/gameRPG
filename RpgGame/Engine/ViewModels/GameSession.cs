using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Engine.Model;
using Engine.Models;
using Engine.Factories;
using System.ComponentModel;

namespace Engine.ViewModels
{
    public class GameSession
    {

        //#TODO: create a save system and up here
        public Player CurrentPlayer { get; set; }

        private Location _currentLocation;
        public Location CurrentLocation { get; set; }
        //{
        //    get
        //    {
        //        return _currentLocation;
        //    }

        //    set
        //    {
        //        if (value != null)
        //            _currentLocation = value;

        //        OnPropertyChanged("CurrentLocation");
        //    }
        //}
        public World CurrentWorld { get; set; }

        //Event Subscription
        




        public GameSession()
        {
            CurrentPlayer = new Player()
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

        

        public void MoveNorth()
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1);

            //CurrentLocation = CurrentWorld.LocationAt(0,0);
            //CurrentLocation.ImageName = @"C:\Users\Barzarin\Documents\GitHub\gameRPG\RpgGame\Engine\Images\Location\Istana.jpg";
            //OnPropertyChanged("ImageName");
        }

        public void MoveSouth()
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 1);
        }
        public void MoveEast()
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate);
        }

        public void MoveWest()
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate);
        }


        //Location Update
        public bool[] UpdateLocation()
        {
            bool[] result = new bool[4] {HasLocationNorth(), HasLocationSouth(), HasLocationEast(), HasLocationWest()};

            return result;
                
        }

        //Location Check 
        private bool HasLocationNorth()
        {
            return CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1) != null;
        }
        private bool HasLocationSouth()
        {
            return CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 1) != null;
        }
        private bool HasLocationEast()
        {
            return CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate) != null;
        }
        private bool HasLocationWest()
        {
            return CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate) != null;
        }





        //public event PropertyChangedEventHandler PropertyChanged;

        //public virtual void OnPropertyChanged(string propertyName)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}

    }


}
