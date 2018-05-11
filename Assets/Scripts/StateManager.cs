using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour {

    public Generator[] generators;
    public EMPTerminal[] EMPs;
    public Cog[] cogs;
    public Nutech nt;

	// Use this for initialization
	void Start () {

        generators = FindObjectsOfType<Generator>();
        EMPs = FindObjectsOfType<EMPTerminal>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GeneratorDestroyed()
    {
        Debug.Log("You just lost a generator!");

    }
    public void EMPActivated()
    {
        Debug.Log("You activated a terminal!!!!!");
    }
}
