using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_project_idf
{   
    
    internal class Hamas
    {
        Terorist terorist;
        private string dateOfEstablishment;
        private string commandInChief;
        
        List<Terorist> listTerorists = new List<Terorist>();


        public Hamas(string commandInChief)
        {

            this.dateOfEstablishment = "";
            this.commandInChief = commandInChief;
            

        }
        public void addToListTerorist(string name)
        {
            terorist = new Terorist(name);
            listTerorists.Add(terorist);
        }
        public string removeTerorist(Terorist name)
        {   
            
            if (listTerorists.Contains(name)) 
            {
                listTerorists.Remove(name);
            }
             return null;   
        }
        public string getRank(Terorist name)
        {
            int max = 0;
            foreach(Terorist t in listTerorists)
            {
                int som = t.rank * t.weapon;
                if ( < max)
                {

                }
            }

            
            return null;
        }



        public void getdateOfEstablishment()
        {
            Console.WriteLine(this.dateOfEstablishment);
        }

        public void setcommandInChief(string commandInChief)
        {
            this.commandInChief = commandInChief;
        }

        public void getcommandInChief()
        {
            Console.WriteLine(this.commandInChief);
        }

        public List<Terorist> getListTerorist()
        {
            return listTerorists;
        }


    }
}
