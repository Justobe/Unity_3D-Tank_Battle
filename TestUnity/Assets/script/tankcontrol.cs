using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankcontrol : MonoBehaviour {

    // Use this for initialization
    Vector3 dis;
    GameObject detonator;
    GameObject tank;
    GameObject tower;
    GameObject mainCam;
    GameObject aboveCam;
    GameObject forwardCam;
    GameObject mybullet;
    float mousexDis;
    float mouseyDis;
    float life = 100;
	void Start () {
        dis = transform.position - Camera.main.transform.position;
        detonator = Resources.Load("explosion") as GameObject;
        mybullet = Resources.Load("mybullet") as GameObject;
        mainCam = GameObject.Find("MainCamera");
        aboveCam = GameObject.Find("CameraAbove");
        forwardCam = GameObject.Find("CameraForward");

	}
	
    void setAllCamFalse()
    {
        mainCam.SetActive(false);
        aboveCam.SetActive(false);
        forwardCam.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("bullet"))
        {
            life--;
        }
        
    }
    // Update is called once per frame
    void Update () {
        mousexDis = Input.GetAxis("Mouse X");
        transform.FindChild("Tower").Rotate(0, 0, mousexDis*5);
        mouseyDis = Input.GetAxis("Mouse Y");
        Debug.Log(life);
        if(aboveCam.activeSelf == true)
        {
            float angle = aboveCam.transform.eulerAngles.x;
            aboveCam.transform.Rotate(-mouseyDis,0,0);
            
           
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            GameObject tempBullet =  GameObject.Instantiate(mybullet, transform.FindChild("Tower").FindChild("bullet").position, transform.FindChild("Tower").rotation) as GameObject;
            Rigidbody temprig = tempBullet.GetComponent<Rigidbody>();
            temprig.AddRelativeForce(Vector3.up*2000);

        }

        if (Input.GetKey(KeyCode.W))
           {
                transform.Translate(10 * Time.deltaTime, 0, 0);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(-10 * Time.deltaTime, 0, 0);
            }
            else if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(Vector3.up, -1);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(Vector3.up, 1);
            }

        if (Input.GetKey(KeyCode.F1))
        {
            setAllCamFalse();
            aboveCam.SetActive(true);
        }
        else if (Input.GetKey(KeyCode.F2))
        {
            setAllCamFalse();
            forwardCam.SetActive(true);
        }


        


    }
}
