﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : Pickup {

    public Rigidbody projectile;
    public float speed = 50;
    public float projectileLifespan = 3f;

    public float fireRate = 0.11f;
    private float lastShot = -10.0f;

    public Pickup augment;

    Rigidbody clone;

    public void Fire()
    {
        if (Time.time > fireRate + lastShot)
        {
            clone = Instantiate(projectile, transform.position, transform.rotation);
            //projectile.tag = "Bullet";
            clone.velocity = transform.TransformDirection(new Vector3(0, 0, speed));

            lastShot = Time.time;
        }
        Destroy(clone.gameObject, projectileLifespan);
    }

    public override void Interact(GameObject player)
    {
        GrabPickup(player);
    }

    public override void GrabPickup(GameObject player)
    {
        Gun oldGun = player.GetComponentInChildren<Gun>();
        Transform gunLoc = player.transform.Find("GunLoc");

        if (oldGun)
        {
            Debug.Log("There's a gun");
            oldGun.transform.parent = null;

            transform.position = gunLoc.position;
            transform.parent = gunLoc;
        }
        else
        {
            Debug.Log("There's no gun");
            transform.position = gunLoc.position;
            transform.parent = gunLoc;
        }
        player.GetComponent<CharacterInput>().currGun = this;
    }
}
