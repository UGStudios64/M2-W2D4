using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Utilizzando il ciclo for, stampare la tabellina del 5

public class ExerciseEX : MonoBehaviour
{
    [SerializeField] int numb;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i <= 10; i++)
        {
            Debug.Log(numb * i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
