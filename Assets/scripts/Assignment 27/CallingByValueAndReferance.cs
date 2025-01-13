using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment27
{
    public class CallingByValueAndReferance : MonoBehaviour
    {
        void Start()
        {
            int number1 = 10;
            int number2 = 20;
            int number3;

            modifyNumber(number1);
            Debug.Log(number1);

            modifyNumber2(ref number2);
            Debug.Log(number2);

            assignNumber(out number3);
            Debug.Log(number3);

        }

        public void modifyNumber(int num)
        {
            num += 15;
        }

        public void modifyNumber2(ref int num)
        {
            num -= 5;
        }

        public void assignNumber(out int num)
        {
            num = 20;
        }
    }
}