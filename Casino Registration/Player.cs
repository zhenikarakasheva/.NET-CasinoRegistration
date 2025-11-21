using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino_Registration
{
    //A simple class describing each player enrolled in this casino - they have an username, names and age
    public class Player
    {
        public string Username { get; set; }
        public string Names { get; set; }
        public int Age { get; set; }
        public Player(string username, string names, int age)
        {
            Username = username;
            Names = names;
            Age = age;
        }

        public override string ToString()
        {
            return $"Username: {Username} Names: {Names} Age: {Age}";
        }
    }
}
