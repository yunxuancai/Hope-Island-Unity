﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    public float Damage { get; set; }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Enemy" && !GetComponentInParent<PlayerMovement>().AttackedEnemies.Contains(other.GetInstanceID()))
        {
            GetComponentInParent<PlayerMovement>().AttackedEnemies.Add(other.GetInstanceID());
            other.GetComponent<FootmanScript>().setDamage((int)Damage);
        }
    }
}
