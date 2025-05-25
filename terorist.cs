using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_project_idf
{
    internal class Terorist
    {   
        
        Random random = new Random();
        
        private string name;
        public int rank;
        private bool aliveOrDead;
        public Dictionary<string,int> weapon;

     
        private int [] listrank;
        public Terorist(string name) 
        {
            this.name = name;
            this.aliveOrDead = true;

            weapon = new Dictionary<string, int>()
            {
                { "M16", 2 },
                { "AK47", 3 },
                { "gun", 1 },
                { "knife", 1 }
            };

            listrank = new int[] { 1, 2, 3, 4, 5};


        }
        
        public void addTerorist(string name)
        {   
            int numRnd1 = random.Next(0, listweapon.Length);
            int numRnd2 = random.Next(0,5);

            this.weapon = listweapon[numRnd1];
            this.rank = listrank[numRnd2];

            

        }
        
        




    }
}
