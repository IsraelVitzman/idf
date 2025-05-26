using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace OOP_project_idf
{
    internal class Ahman
    {
         static Dictionary<string, List<Ahman>> terorists = new Dictionary<string, List<Ahman>>();

        
        private string loction;
        private string date;

        public Ahman()
        {
            
            this.loction="";
            
        }

        public void addTerorist(string name, string loction, string cooch)
        {
            if (cooch.Equals("1"))
            {
                this.loction = "home";
            }
            else if (cooch.Equals("2"))
            {
                this.loction = "outside";
            }
            else
            {
                Console.WriteLine("invalid");
                return;
            }  
            this.date = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            if (!terorists.ContainsKey(name))
            {
                terorists[name] = new List<Ahman>();


            }
            terorists[name].Add(this);


        }
        public string getLoction(string name)
        {

            if (terorists.ContainsKey(name))
            {
                return terorists[name].Last().loction;
            }
            return "not found";

        }
        public string mostAlerts()
        {   
            int max = 0;
            string data = "";
            foreach (string name in terorists.Keys)
            {
                if (terorists[name].Count >  max)
                {
                    max = terorists[name].Count;
                    data = name;
                }

            }
            return $"data{data}max{max}";
            
            

        }






    }
}
