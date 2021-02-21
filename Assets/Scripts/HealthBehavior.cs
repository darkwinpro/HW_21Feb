using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBehavior : MonoBehaviour
{
    
    public float MaXHealth { get; set; }
    
    public float Health { get; set; }

    private void Awake()
    {
        MaXHealth = 1000;
        Health = 1000;
    }

}
