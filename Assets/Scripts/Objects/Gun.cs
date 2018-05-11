using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : Pickup {

    public Rigidbody projectile;
    public float speed = 50;
    public float projectileLifespan = 3f;

    public float fireRate = 0.11f;
    private float lastShot = -10.0f;

    public Vector3 offsetPos;
    public Quaternion offsetRot;

    public Pickup augment;

    Rigidbody clone;

    public void augmentGun()
    {
        
    }


    public void Fire()
    {
        if (Time.time > fireRate + lastShot)
        {
            clone = Instantiate(projectile, transform.position + offsetPos, transform.rotation);
            //projectile.tag = "Bullet";
            clone.velocity = transform.TransformDirection(new Vector3(0, speed, 0));

            lastShot = Time.time;
        }
        Destroy(clone.gameObject, projectileLifespan);
    }

    public override void Interact(GameObject player)
    {
        if (player.tag == "Cog")
        {
            GrabPickup(player);
        }
    }

    public override void GrabPickup(GameObject player)
    {
        Gun oldGun = player.GetComponentInChildren<Gun>();
        Transform gunLoc = player.transform.Find("GunLoc");

        if (oldGun)
        {
            //Debug.Log("There's a gun");         

            transform.parent = gunLoc;
            transform.position = gunLoc.position;

            Gun[] guns = player.GetComponentsInChildren<Gun>();
            for(int i = 0; i < guns.Length; i++)
            {
                Debug.Log(guns[i]);
                if (guns[i] == this.transform)
                {
                    player.GetComponent<CharacterInput>().currGun = this;
                    oldGun.transform.parent = null;
                    //oldGun.Idle();
                }
            }
        }
        //else
        //{
        //    //Debug.Log("There's no gun");
        //    transform.position = gunLoc.position;
        //    transform.parent = gunLoc;
        //}
        player.GetComponent<Cog>().currGun = this;
    }

    public override void Idle()
    {
        throw new System.NotImplementedException();
    }

    //internal void meleeAttack(GameObject target)
    //{
    //    throw new NotImplementedException();
    //}
}
