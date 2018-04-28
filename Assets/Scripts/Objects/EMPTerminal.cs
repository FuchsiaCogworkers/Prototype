using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EMPTerminal : Interactable {
    public bool activated = false;

    public override void Interact(GameObject player)
    {
        if(player.tag == "Cog")
        {
            activated = true;
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
