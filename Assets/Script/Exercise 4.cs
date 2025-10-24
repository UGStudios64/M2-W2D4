using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise4 : MonoBehaviour
{
    [SerializeField] int startnumber;
    [SerializeField] int amount;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= amount; i++)
        {
            Debug.Log(startnumber);
            startnumber++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
