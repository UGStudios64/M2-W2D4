using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise3 : MonoBehaviour
{
    [SerializeField] int value = 30;

    void Start()
    {
        for (int i = 1; i <= value; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Debug.Log("FizzBuzz");
            }
            else if (i % 5 == 0)
            {
                Debug.Log("Buzz");
            }
            else if (i % 3 == 0)
            {
                Debug.Log("Fizz");
            }
            else
            {
                Debug.Log(i);
            }
        }
    }
}