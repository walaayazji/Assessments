using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

namespace Assignment14
{
    public class Player : Character
    {
        public Player(string name , int health) : base (name,health)
        {

        }

        public void Heal(int amount)
        {
            Health += amount;
        }
    }   
}

