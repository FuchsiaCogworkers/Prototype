﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    public Rigidbody projectile;
    public float speed = 50;

    float fireRate = 0.11f;
    private float lastShot = -10.0f;
    Rigidbody clone;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (Time.time > fireRate + lastShot)
            {
                clone = Instantiate(projectile, transform.position, transform.rotation);
                projectile.tag = "Bullet";
                clone.velocity = transform.TransformDirection(new Vector3(0, 0, speed));

                lastShot = Time.time;
            }
            Destroy(clone.gameObject, 3);
        }
    }
}