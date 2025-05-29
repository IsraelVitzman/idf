using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_project_idf
{
    internal class Terorist
    {
        static Random random = new Random(); 

        public string name;
        public int rank;
        public int weapon;
        private bool aliveOrDead;
        
        public Dictionary<string, int> dictWeapon;
        private int[] listrank;

        public Terorist(string name)
        {
            this.name = name;
            this.aliveOrDead = true;
            dictWeapon = new Dictionary<string, int>()
            {
                { "M16", 3 },
                { "AK47", 3 },
                { "gun", 1 },
                { "knife", 1 }
            };
            listrank = new int[] { 1, 2, 3, 4, 5 };
        }

        public void addTerorist(string name)
        {
            int numRnd1 = random.Next(0, 4); 
            int numRnd2 = random.Next(0, 5); 

           
            this.weapon = dictWeapon.Values.ElementAt(numRnd1);
            this.rank = listrank[numRnd2];
        }

        public bool alive() 
        {
            return aliveOrDead;
        }
    }
}