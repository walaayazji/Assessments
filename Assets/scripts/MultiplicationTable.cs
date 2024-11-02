using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplicationTable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int  Multiply (int number1, int number2){
        int sum = number1 * number2;
        return sum;
        }

        for (int i= 1; i<=10; i++){
        int j= Multiply(5,i);
        Debug.Log($"5 * {i} = {j}");

    }


    }
}