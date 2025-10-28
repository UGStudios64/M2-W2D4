using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise1 : MonoBehaviour
{
    [SerializeField] int index;
    [SerializeField] int num;

    void Start()
    {
        while (index > 0)
        {
            num++;
            Debug.Log(num);
            index--;
        }
        Debug.Log("done");
    }

}
