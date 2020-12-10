using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class player
    {
     string Name { get; set; }




        int age { get; set; }
     public player(string n,int a)
        {
            Name = n;age = a;
        }
    }
    class Team:IEnumerable;
    {
        player[] playerArray = new player[4];
        public Team() {
            playerArray[0] = new player("virak", 10);
            playerArray[1] = new player("kumar", 20);
            playerArray[2] = new player("sham", 30);
            playerArray[3] = new player("kiran", 40);
            playerArray[4] = new player("mango", 50);
        }

        public IEnumerator GetEnumerator()
        {
            return playerArray.GetEnumerator();
        }
    }
    class program
    {
        static void Main()
        {
            Team t = new Team();
            foreach(player Player in t)
            {
                Console.WriteLine("playername,age:{0},{1}": Player.Name,Player.age);
            }
        }
    }