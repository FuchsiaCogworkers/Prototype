using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

    public Gun currGun;
    public GameObject gunCogment;
    public GameObject cogCogment;

    //Projectile projectile;
    // Use this for initialization
	void Start () {

        currGun = GetComponent<Gun>();
	}
	
	// Update is called once per frame
	void Update () {
		if(GetComponent<Gun>() != currGun)
        {
            currGun = GetComponent<Gun>();
        }
	}

    void DropGun()
    {

    }

    //void ChangeGun(GameObject newGun)
    //{
    //    //Debug.Log(newGun);
    //    //Debug.Log(newGun.speed);
    //    if(currGun != null)
    //    {
    //        //drop the current gun as a game object
    //        //Vector3 dropLoc = new Vector3(transform.x, transform.y, transform.z);
    //        Instantiate(currGun, new Vector3(transform.position.x+25, transform.position.y+25, transform.position.z), Quaternion.Euler(new Vector3(transform.rotation.x, transform.rotation.y)));
    //    }
    //    Debug.Log(newGun);
    //    Debug.Log(newGun.GetComponent<Gun>().speed);
    //    currGun = newGun;
    //    Debug.Log(newGun);
    //    Debug.Log(newGun.GetComponent<Gun>().speed);
    //    //SendMessage("UpdateGun");
    //}
}
