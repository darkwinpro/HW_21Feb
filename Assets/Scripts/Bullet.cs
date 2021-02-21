using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] 
    private int _ricochet = 4;
    
    private void OnCollisionEnter(Collision collision)
    {
        var damaded = collision.gameObject.GetComponent<EnemyController>();
        
        
        if (_ricochet >= 0 && !damaded)
        {
            _ricochet -= 1;
            
            if (damaded)
            {
               damaded.OnHit();
            }
        }
        else 
        { 
           Destroy(gameObject); 
        }
    }
}
