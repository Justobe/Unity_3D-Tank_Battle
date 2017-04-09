using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class helpPageControl : MonoBehaviour {

    // Use this for initialization
    GameObject escImg;
    Button btnEsc;
	void Start () {
        escImg = GameObject.Find("Esc") as GameObject;
        btnEsc = escImg.GetComponent<Button>();

        btnEsc.onClick.RemoveAllListeners();
        btnEsc.onClick.AddListener(delegate()
        {
            btnEscClick(escImg);
        });
	}

    private void btnEscClick(GameObject escImg)
    {
        SceneManager.LoadScene("start");   
    }

    // Update is called once per frame
    void Update () {
		
	}
}
