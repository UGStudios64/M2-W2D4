using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise5 : MonoBehaviour
{
    [SerializeField] int numberToFind;
    [SerializeField] int arraySize;
    [SerializeField] int numberOffset;

    void Start()
    {
        int max = numberToFind + numberOffset;
        int min = numberToFind - numberOffset;

        int[] array = new int[arraySize];

        for (int i = 0; i < arraySize; i++)
        {
            array[i] = Random.Range(min, max);
            if (array[i] == numberToFind)
            {
                Debug.Log("Found");
            }
            Debug.Log("Not Found");
        }
        Debug.Log("Finish Iteration");
    }
}
