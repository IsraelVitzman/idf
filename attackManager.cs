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

    }
}
