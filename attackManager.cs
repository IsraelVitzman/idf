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
        F16FighterJet f16FighterJet=new F16FighterJet();
        M109Artillery m109Artillery = new M109Artillery();

        Hamas hamas = new Hamas();
        Ahman ahman = new Ahman();
        List<Terorist> terorists = new List<Terorist>();

        public void status()
        {
            hermes460_Zik_Drone.Strike();
            f16FighterJet.Strike();
            m109Artillery.Strike();
        }
        
        public int getNumberOfHitsf16()
        {
            return f16FighterJet.NumberOfHits();
        }
        public int getNumberOfHitszik()
        {
            return hermes460_Zik_Drone.NumberOfHits();
        }
        public int getNumberOfHitsm109()
        {
            return m109Artillery.NumberOfHits();
        }
        
        public void attackTerorist()
        {
            

            var getName=hamas.getRank(); 
            var loction=ahman.getLoction(getName);
            usToAtack(loction);
            hamas.removeTerorist(getName);
            Console.WriteLine("remuve sscfoly");
        }
        public void usToAtack(string loction)
        {
            int numberOfHits = f16FighterJet.NumberOfHits();

            if (loction.Equals("home")){
                f16FighterJet.Strike();
                Console.WriteLine(f16FighterJet.NumberOfHits()); 

                if (numberOfHits > 0)
                {
                    f16FighterJet.setNumberOfHits(numberOfHits-1);
                }
                
            }
            else if (loction.Equals("outside"))
            {
                Console.WriteLine(hermes460_Zik_Drone.NumberOfHits());
                hermes460_Zik_Drone.Strike();
                if (numberOfHits > 0)
                {
                    hermes460_Zik_Drone.setNumberOfHits(numberOfHits - 1);
                }

            }
            else 
            {
                Console.WriteLine("invalid");
            }

        }
        

    }
}
