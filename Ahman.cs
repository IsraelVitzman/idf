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
            this.loction = "";
        }

        public Ahman(string loction, string date) 
        {
            this.loction = loction;
            this.date = date;
        }

        public void addTerorist(string name, string cooch)
        {
            string actualLocation; 
            if (cooch.Equals("1"))
            {
                actualLocation = "home"; 
            }
            else if (cooch.Equals("2"))
            {
                actualLocation = "outside"; 
            }
            else
            {
                Console.WriteLine("invalid");
                return;
            }

            string currentDate = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"); 

            if (!terorists.ContainsKey(name))
            {
                terorists[name] = new List<Ahman>();
            }

            // **שינוי עיקרי: יוצר instance חדש במקום להוסיף this**
            Ahman newReport = new Ahman(actualLocation, currentDate);
            terorists[name].Add(newReport);
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
                if (terorists[name].Count > max)
                {
                    max = terorists[name].Count;
                    data = name;
                }
            }
            return $"data: {data}, max: {max}"; // **שינוי: הוספתי רווחים וכפתור**
        }
    }
}