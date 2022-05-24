using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private Transform firePoint;

    [SerializeField] private GameObject fireBall;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Fire()
    {
        Instantiate(fireBall, firePoint.position, firePoint.rotation);
        Debug.Log("Fire called");
    }
    
}