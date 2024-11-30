using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

namespace Assignment14
{
    public class Enemy : Character
    {
        public Enemy(string name , int health) : base (name,health)
        {

        }

        public void Attack(int amount)
        {
            Health -= amount;
        }
    }   
}

