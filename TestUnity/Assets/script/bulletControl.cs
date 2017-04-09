using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletControl : MonoBehaviour {

    // Use this for initialization
    static GameObject detonator;
	void Start () {
        detonator = Resources.Load("detonator") as GameObject;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        
        Vector3 position = transform.position;
        Debug.Log(position);
        GameObject tempexp = GameObject.Instantiate(detonator, position, Quaternion.identity);
        Destroy(tempexp, 2.0f);
        Destroy(transform.gameObject, 2.0f);
    }
}
