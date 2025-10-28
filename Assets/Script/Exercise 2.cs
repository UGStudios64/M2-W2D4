using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise2 : MonoBehaviour

{
    [SerializeField] int[] numeri;
    int somma;
    int multi = 1;

    void Start()
    {
        for(int i = 0;  i < numeri.Length; i++)
        {
            somma += numeri[i];
            multi *= numeri[i];
        }
        Debug.Log($"la somma é {somma}");
        Debug.Log($"Il loro prodotto é {multi}");
    } 
}
