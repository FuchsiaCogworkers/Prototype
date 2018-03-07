using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pickup : Interactable {

    //method that handles what happens when object is picked up
    public abstract void GrabPickup(GameObject player);

    //method that handles what the object does while not picked up
    public abstract void Idle();
}
