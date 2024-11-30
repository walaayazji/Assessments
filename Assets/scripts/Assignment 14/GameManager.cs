using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment14
{
public class GameManager : MonoBehaviour
{
    void Start()
    {
      Player player= new Player("Subhi",60);
      Enemy enemy = new Enemy("Zarifeh",75);

      Debug.Log(player.Name+"'s Health: " +player.Health);
      Debug.Log(enemy.Name+"'s Health: " +enemy.Health);

      player.Heal(20);
      Debug.Log(player.Name+ "'s Health after Healing: " +player.Health);


      enemy.Attack(10);
      Debug.Log(enemy.Name + "'s Health after Attacking: " +enemy.Health);

    }
}
}