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

        static List<Terorist> listTerorists = new List<Terorist>();

        public Hamas()
        {
            this.dateOfEstablishment = "1987";
            this.commandInChief = "";
        }

        public void addToListTerorist(string name)
        {
            terorist = new Terorist(name);
            terorist.addTerorist(name); 
            listTerorists.Add(terorist);
        }

        public string removeTerorist(string name)
        {
            
            int removedCount = listTerorists.RemoveAll(t => t.name.Equals(name));
            if (removedCount > 0)
            {
                return $"Removed {removedCount} terrorist(s) named {name}";
            }
            return "Terrorist not found";
        }

        public string getRank()
        {
            if (listTerorists.Count == 0) 
            {
                return "";
            }

            string resultName = "";
            int max = 0;

            foreach (Terorist t in listTerorists)
            {
                int result = t.rank * t.weapon;
                if (result > max)
                {
                    max = result;
                    resultName = t.name;
                }
            }
            Console.WriteLine($"{resultName} threat level: {max}"); 
            return resultName;
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