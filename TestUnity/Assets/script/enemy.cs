using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class enemy : MonoBehaviour
{

    // Use this for initialization
    Vector3 target;
    GameObject player;
    GameObject detonator;
    GameObject mybullet;
    GameGod helpGod;
    float time = 6;
    float life = 100;

    //float time = 10;
    void Start()
    {
        helpGod = new GameGod();
        player =  GameObject.Find("Tank");
        mybullet = Resources.Load("mybullet") as GameObject;
        detonator = Resources.Load("explosion") as GameObject;
    }
    bool isAlive()
    {
        if (this.life >= 0)
            return true;
        else
            return false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            life-=10;
        }

    }
    // Update is called once per frame
    void Update()
    {
        //time -= Time.deltaTime;
        if (isAlive())
        {
            float xDis = Mathf.Abs(transform.position.x - player.transform.position.x);
            float zDis = Mathf.Abs(transform.position.z - player.transform.position.z);
            // arrive at tank
            if (xDis < 30 && zDis < 30)
            {

                target = player.transform.position - transform.position;
                transform.right = target;
                if (time > 5)
                {
                    time = 0;
                    GameObject tempBullet = GameObject.Instantiate(mybullet, transform.FindChild("Tower").FindChild("bullet").position, transform.FindChild("Tower").rotation) as GameObject;
                    Rigidbody temprig = tempBullet.GetComponent<Rigidbody>();
                    temprig.AddRelativeForce(Vector3.up * 2000);
                }
                else
                {
                    time += Time.deltaTime;
                }


            }
            else
            {
                target = player.transform.position - transform.position;
                transform.right = target;
                transform.Translate(10 * Time.deltaTime, 0, 0);
                return;
            }

        }
        else
        {
            Rigidbody rig =  transform.gameObject.GetComponent<Rigidbody>();
            rig.isKinematic= true;
        }

    }
}
