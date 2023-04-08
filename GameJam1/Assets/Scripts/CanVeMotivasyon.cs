using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanVeMotivasyon : MonoBehaviour
{
    public int maxMotive = 100;
    public int currentMotive = 100;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void motiveChange(int value)
    {
        currentMotive += value;
        if (currentMotive <= 0)
        {
        Debug.Log("Yıldım daa!");    
        }
    }
}




