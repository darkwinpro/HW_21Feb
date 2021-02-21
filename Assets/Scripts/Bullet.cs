using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Damage => _damage;
    [SerializeField] 
    private int _ricochet = 4;

    [SerializeField] 
    private float _damage = 10;
    
    
    private void OnCollisionEnter(Collision collision)
    {
        var damaged = collision.gameObject.GetComponent<EnemyController>();

        if (damaged != null)
        {
            damaged.OnHit(_damage);
        }

        _ricochet -= 1;
        if (_ricochet <= 0 || damaged != null)
        {
            Destroy(gameObject);
        }
    }
}       // BY MY:
        // if (_ricochet > 0)
        // {
        //     _ricochet -= 1;
        //     
        //     if (damaged)
        //     {
        //         damaged.OnHit(_damage);
        //         Destroy(gameObject); 
        //     }
        // }
        // else
        // {
        //     Destroy(gameObject);
        // }
 
