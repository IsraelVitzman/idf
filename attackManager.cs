using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp27;

namespace OOP_project_idf
{
    internal class attackManager
    {
        Hermes460_Zik_Drone hermes460_Zik_Drone = new Hermes460_Zik_Drone();
        F16FighterJet f16FighterJet = new F16FighterJet();
        M109Artillery m109Artillery = new M109Artillery();
        Hamas hamas = new Hamas();
        Ahman ahman = new Ahman();

        public void status()
        {
            hermes460_Zik_Drone.Strike();
            f16FighterJet.Strike();
            m109Artillery.Strike();
        }

        public void attackTerorist()
        {
            var getName = hamas.getRank();
            if (getName == null || getName == "") 
            {
                Console.WriteLine("No terrorists available to attack");
                return;
            }

            var loction = ahman.getLoction(getName);
            if (loction == "not found") 
            {
                Console.WriteLine("No intelligence available for this terrorist");
                return;
            }

            usToAtack(loction, getName); 
            hamas.removeTerorist(getName);
            Console.WriteLine("removed successfully"); 
        }

        public void usToAtack(string loction, string terroristName) 
        {
            if (loction.Equals("home"))
            {
                int numberOfHits = f16FighterJet.NumberOfHits(); 
                f16FighterJet.Strike();
                Console.WriteLine(f16FighterJet.NumberOfHits());
                if (numberOfHits > 0)
                {
                    f16FighterJet.setNumberOfHits(numberOfHits - 1);
                }
            }
            else if (loction.Equals("outside"))
            {
                int numberOfHits = hermes460_Zik_Drone.NumberOfHits(); 
                Console.WriteLine(hermes460_Zik_Drone.NumberOfHits());
                hermes460_Zik_Drone.Strike();
                if (numberOfHits > 0)
                {
                    hermes460_Zik_Drone.setNumberOfHits(numberOfHits - 1);
                }
            }
            else
            {
                Console.WriteLine("invalid location");
            }
        }
    }
}
