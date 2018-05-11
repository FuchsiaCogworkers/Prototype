using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour {

    private StateManager sm;

	// Use this for initialization
	void Start () {
        sm = FindObjectOfType<StateManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnDestroy()
    {
        sm.SendMessage("GeneratorDestroyed");
    }
}
