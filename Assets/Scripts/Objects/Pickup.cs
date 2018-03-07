using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pickup : Interactable {

    public abstract void GrabPickup(GameObject player);
}
