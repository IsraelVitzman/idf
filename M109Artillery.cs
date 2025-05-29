using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp27;

namespace OOP_project_idf
{
    internal class M109Artillery : StrikeUni
    {
        private string nameForValidity;
        private int numberOfHits;
        private int fuel;
        private string efficiency;
        private string pylot;
        private string bomb;

        public M109Artillery()
        {
            nameForValidity = "M109 Artillery";
            numberOfHits = 40;
            fuel = 100;
            efficiency = "open spaces";
            bomb = "Explosive shells";
            pylot = ""; 
        }

        public void Strike()
        {
            Console.WriteLine($"Strike initiated with: {nameForValidity}, Hits: {numberOfHits}, Fuel: {fuel}, Efficiency: {efficiency}, pylot: {pylot}, bomb: {bomb}");
        }

        public int setNumberOfHits(int numberOfHits)
        {
            this.numberOfHits = numberOfHits;
            return this.numberOfHits;
        }

        public int NumberOfHits()
        {
            return numberOfHits;
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