using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Assignment8 : MonoBehaviour
{
    void Start()
    {

        //Exercise 1
        while (true) {
            int randomNumber = Random.Range(1,21);
            Debug.Log(randomNumber);
            if (randomNumber == 5) continue ;  
            if (randomNumber == 15) break  ;
         }   

        //Exercise 2
        string[] words = { "Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird" }; 
        int counter = 0; 
        string finalSentence = "";
 
        while (counter < 7) { 
            int randomIndex = Random.Range(0, words.Length); 
            finalSentence += words[randomIndex] + " ";  
            counter++;
        } 
        
        Debug.Log(finalSentence); 


    }
}

