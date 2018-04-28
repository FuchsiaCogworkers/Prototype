using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour {

    // public float interactTime;

    //method called when player interacts with object
    public abstract void Interact(GameObject player);

}
