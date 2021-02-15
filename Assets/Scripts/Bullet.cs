using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] 
    private int _ricochet = 4;

    private void OnCollisionEnter(Collision collision)
    {
        if (_ricochet >= 0)
        {
            _ricochet -= 1;
        }
        else
        {
            Destroy(gameObject); 
        }
    }
}
