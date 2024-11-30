using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace Assignment18
{
    public class Character
    {
        public string name;
        private int health;
        protected Position position;

        public int Health
        {
            get {return health;}
            set { if (value> 100) health=100;
                else if (value<0) health=0;
                else health= value;}
        } 

        
        public Character(string name, int health, Position position)
        {
            this.name=name;
            this.Health=health;
            this.position= position;
        }

        public Character() : this ("No name",100,new Position(0,0,0))
        {
        }

        public virtual void DisplayInfo()
        {
            
            Debug.Log($"Name: {name}, Health: {Health}");
            position.printPosition();
        }

        public void Attack(int damage, Character target)
        {
            target.Health -= damage;
            Debug.Log($"{target.name}'s health: {target.Health}");
        }

        public void Attack(int damage, Character target, string attackType)
        {
            target.Health -= damage;
            Debug.Log($"{target.name}'s health after {name}'s {attackType}: {target.Health}");
        }      
    }         
}