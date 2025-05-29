using System;

namespace ConsoleApp27
{
    internal class F16FighterJet : StrikeUni
    {
        private string nameForValidity;
        private int numberOfHits;
        private int fuel;
        private string efficiency;
        private string pylot;
        private string bomb;

        public F16FighterJet()
        {
            nameForValidity = "F16FighterJet";
            numberOfHits = 8;
            fuel = 100;
            efficiency = "building"; 
            pylot = "Operated by a pilot";
            bomb = "0.5 ton or 1 ton";
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