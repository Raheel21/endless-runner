using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[Serializable]
public class Stat
{
    [SerializeField]
    private Healthbar healthbar;

    [SerializeField]
    private float maxVal;

    [SerializeField]
    private float currentVal;

    public float CurrentVal
    {
        get
        {
            return currentVal;
        }

        set
        {
            

            currentVal = Mathf.Clamp(value, 0, MaxVal);
            healthbar.Value = currentVal; 
            
        }
    }

    public float MaxVal
    {
        get
        {
            return maxVal;
        }

        set
        {
            maxVal = value;
            healthbar.MaxValue = maxVal; 

        }
    }

    public void Initialize()
    {
        MaxVal = maxVal;
        CurrentVal = currentVal; 
    }
}
