using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EMPTerminal : Interactable {
    public bool activated = false;
    private StateManager sm;

    public override void Interact(GameObject player)
    {
        if(player.tag == "Cog")
        {
            activated = true;
            sm.SendMessage("EMPActivated");
        }
    }

    // Use this for initialization
    void Start () {
        sm = FindObjectOfType<StateManager>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
