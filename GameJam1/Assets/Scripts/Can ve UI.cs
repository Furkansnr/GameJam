using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanveUI : MonoBehaviour
{
    public int maxMotivation = 100;
    public int currentMotivation = 100;

    public void motivationChange(int value)
    {
        if (currentMotivation <= 0)
        {
         Debug.Log("GameOver");   
        }   
    }
}
