using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour {

    public Generator[] generators;

	// Use this for initialization
	void Start () {

        generators = FindObjectsOfType<Generator>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GeneratorDestroyed()
    {
        Debug.Log("You just lost a generator!");
    }
}
