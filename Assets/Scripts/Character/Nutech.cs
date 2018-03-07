using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nutech : CharacterInput
{
    public float experience = 0;
    //public float attackExpVal;

    public float meleeDamage;

    void MeleeAttack(GameObject target)
    {
        target.GetComponent<Cog>().TakeDamage(meleeDamage);
    }

    void GainExp(float val)
    {
        experience += val;
    }

    public override void OnTriggerStay(Collider other)
    {
        //handles interacting with Interactable objects
        if (Input.GetButton("Interact"))
        {
            other.GetComponent<Interactable>().Interact(gameObject);
        }

        //handles melee attack
        if (Input.GetButtonDown("Fire2"))
        {
            MeleeAttack(other.gameObject);
        }
    }
}
