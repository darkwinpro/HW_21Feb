using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBehavior : MonoBehaviour
{
    public int MaXHealth { get; private set; }
    public int Health { get; private set; }

    private void Awake()
    {
        MaXHealth = 100;
        Health = 60;
    }

}
