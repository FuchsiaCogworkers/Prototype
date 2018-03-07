using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cog : CharacterInput
{
    public Pickup cogCogment;

    public override void TakeDamage(float damage)
    {
        health -= damage;
        SendMessage("GainExp", damage);
    }
}
