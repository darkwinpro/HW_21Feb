using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private GameObject _bulletPrefab;

    [SerializeField] private float _bulletVelocity = 30f;

    [SerializeField] private AudioSource _shoot;
    
    [SerializeField] private float _shootCooldwn = 0.5f;
    
    private float _nextTimeShot;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (Time.time >= _nextTimeShot )
            {
                _nextTimeShot = Time.time + _shootCooldwn;
                CreateBullet();
            }
        }
    }

    private void CreateBullet()
    {
        GameObject newBullet = Instantiate(_bulletPrefab, transform.position, transform.rotation);
        newBullet.GetComponent<Rigidbody>().velocity = transform.forward * _bulletVelocity;
        _shoot.Play();
    }
}
