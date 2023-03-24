using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

namespace Prograd_Week1_Quiz
{

    public class Dispenser
    {
        public int totalChocolates = 0;
        public Dictionary<string, int> chocolatesColors = new Dictionary<string, int>()
        {
            { "green", 0 },
            { "silver", 0 },
            { "blue",0},
            { "crimson",0},
            { "purple",0},
            { "red",0},
            { "pink",0}
        };

  

        public void addChocolates(string color, int count)
        {
            this.chocolatesColors[color] += count;
        }
        public void removeChocolateOfColor(string color) 
        {
                this.chocolatesColors[color]--;
        }
        public Dictionary<string, int> removeChocolates(int count)
        {
            Dictionary <string,int> result = new Dictionary<string,int>();
            foreach(KeyValuePair<string, int> item in result) 
            {
                result[item.Key] = (result.TryGetValue(item.Key, out var value) ? value : 0) + 1;
            }
        }
        public List<int> dispenseChocolates()
        {
        }
        //[green, silver, blue, crimson, purple, red, pink]
        public Dictionary<string, int> dispenseChocolatesOfColor()
        {
        }
        public void noOfChocolates()
        {

        }
        public List<int> dispenseRainbowChocolates()
        { }
            }
    public class ChocolateMachine
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}