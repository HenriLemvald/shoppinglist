using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FrozenOOP
{
    class Program
    {
        class Gifts
        {
            string earrings;
            string BoxOfChoclates;
            string sleigh;
            string carrots;
            string sunscreen;

            public Gifts(string _Earrings, string BoxOfChocolates, string _Sleigh, string _Carrots, string _Sunscreen)
            {
                earrings = _Earrings;
                BoxOfChoclates = BoxOfChocolates;
                sleigh = _Sleigh;
                carrots = _Carrots;
                sunscreen = _Sunscreen;
           }
            public string Earrings { get{ return earrings; } }
            public string BoxOfChocolates { get { return BoxOfChocolates; } }
            public string Sleigh { get { return sleigh; } }
            public string Carrots { get { return carrots; } }
            public string Sunscreen { get { return sunscreen; } }
        }
        class ListOfGifts
        {
            List<Gifts> gifts;
            int totalGifts;
            
            public ListOfGifts()
        {
            new List<Gifts>();
            totalGifts = 0;
        }
            public void PrtinGiftsList(string earrings, string boxofchocolates, string carrots, string sleigh, string suncreen)
            {
                Gifts newGifts = new Gifts(earrings, boxofchocolates, carrots, sleigh, suncreen);
                gifts.Add(newGifts);
            }
            public void PrintGiftsList()
            {
                foreach (Gifts gifts in gifts)
                {
                    Console.WriteLine($"{gifts.Earrings}.{gifts.BoxOfChocolates}.{gifts.Carrots}.{gifts.Sleigh}.{gifts.Sunscreen}");
                }
            }
        static void Main(string[] args)
            {
                AddGiftsToList();
            }
            public static void AddGiftsToList()
            {
                string filepath = @"C:\Users\opilane\samples";
                string filename = @"frozenl.txt";
                List<Gifts> giftslist = new List<Gifts>();

                List<string> LinesFromFile = File.ReadAllLines(Path.Combine(filepath, filename)).ToList();

                foreach (Gifts gifts in giftslist)
                {
                    Console.WriteLine($"Anna wants {gifts.Earrings} for Christmas");
                    Console.WriteLine($"Elsa wants {gifts.BoxOfChocolates} for Christmas");
                    Console.WriteLine($"Krostoff wants {gifts.Sleigh} for Christmas");
                    Console.WriteLine($"Sven wants {gifts.Carrots} for Christmas");
                    Console.WriteLine($"Olaf want {gifts.Sunscreen} for christmas");
                }
            }
        }
    }
}
