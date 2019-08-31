using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;









//This class is used to create the world, adding all locations to the
//map. New locations can be added here


namespace Engine.Factories
{
    internal class WorldFactory
    {


        internal World CreateWorld()
        {
            //nak dpt path berdasarkan computer masing2
            //var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);

            World newWorld = new World();

            newWorld.AddLocation
                (-1, 0, 
                "Istana",
                "The Seri Menanti Istana, a gleaming stucture that acts as the stronghold for the Sultan",
                @"C:\Users\Barzarin\Documents\GitHub\gameRPG\RpgGame\Engine\Images\Location\Istana.jpg"
                );

            

            return newWorld;

        }
    }
}
