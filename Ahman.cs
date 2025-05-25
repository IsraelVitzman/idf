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

        DateTime dateTime = new DateTime();
        private string loction;
        private string date;

        public Ahman(string loction)
        {
            this.loction = loction;
            
        }

        public void addTerorist(string name, string loction)
        {
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
