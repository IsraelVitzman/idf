using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp27;

namespace OOP_project_idf
{
    internal class Hermes460_Zik_Drone : StrikeUni
    {
        private string nameForValidity;
        private int numberOfHits;
        private int fuel;
        private string efficiency;
        private string bomb;

        public Hermes460_Zik_Drone()
        {
            nameForValidity = "Hermes460 {Zik} Drone";
            numberOfHits = 3;
            fuel = 100;
            efficiency = "people, vehicles";
            bomb = "personnel or armored vehicles";
        }

        public void Strike()
        {
            Console.WriteLine($"Strike initiated with: {nameForValidity}, Hits: {numberOfHits}, Fuel: {fuel}, Efficiency: {efficiency}");
        }

        public int NumberOfHits()
        {
            return numberOfHits;
        }

        public int setNumberOfHits(int numberOfHits)
        {
            this.numberOfHits = numberOfHits;
            return this.numberOfHits;
        }

        public int Fuel()
        {
            return fuel;
        }

        public string Efficiency()
        {
            return efficiency;
        }

        public string NameForValidity()
        {
            return nameForValidity;
        }

        public string Bomb()
        {
            return bomb;
        }
    }
}