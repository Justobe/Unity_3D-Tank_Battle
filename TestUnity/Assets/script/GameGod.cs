using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameGod : MonoBehaviour {


    GameObject enemyTemplate;
    GameObject enemyOne;
    GameObject[] EnemyList;
    static int enemyNum = 5;
    static int leftEnemy = enemyNum;
	void Start () {
        EnemyList = new GameObject[enemyNum];
        enemyTemplate = Resources.Load("Enemy") as GameObject;

         for(int i = 0; i <EnemyList.Length; i++)
         {
            EnemyList[i] = GameObject.Instantiate(enemyTemplate,
                new Vector3(Random.Range(30, 480), 0, Random.Range(30, 480))
                  , Quaternion.identity) as GameObject;
          }
    }

    public static void killOneEnemy()
    {
        leftEnemy--;
    }
    // Update is called once per frame
    void Update () {
       
	}
}
