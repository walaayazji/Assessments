using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18
{
    public class CharacterTest : MonoBehaviour
    {
        void Start()
        {
            Soldier soldier = new Soldier("Walaa",60,new Position(10,0,5));
            Officer officer = new Officer("Khawlah",75,new Position(12,0,3));

            Character[] characters = new Character[] {soldier, officer};
            //  index أستاذ أمين بحثت على النت ولقيتها بتزبط هيك لأنه بالمحاضرة ما زبطتت الا نعرفها باستخدام 

            for (int i = 0; i < characters.Length ; i++)
            {
                characters[i].DisplayInfo();
            }

            soldier.Attack(20,officer,"Kicking");
        }
    }
}