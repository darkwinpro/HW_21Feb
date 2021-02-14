using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField]
    private GameObject _bulletPrefab;
    
    [SerializeField] 
    private float _bulletVelocity = 30f;
    
    [SerializeField]
    private AudioSource _shoot;
    
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            GameObject newBullet = Instantiate(_bulletPrefab, transform.position, transform.rotation);
            newBullet.GetComponent<Rigidbody>().velocity = transform.forward * _bulletVelocity;
            _shoot.Play();
            
        }
    }
}
