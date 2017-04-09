using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class levelPageControl : MonoBehaviour {

    // Use this for initialization
    GameObject escImg;
    GameObject simpleImg;
    GameObject difImg;
    GameObject hellImg;

    Button btnEsc;
    Button btnSim;
    Button btnDif;
    Button btnHell;
    
	void Start () {
        escImg = GameObject.Find("esc") as GameObject;
        simpleImg = GameObject.Find("simple") as GameObject;
        difImg = GameObject.Find("dif") as GameObject;
        hellImg = GameObject.Find("hell") as GameObject;
        
        btnEsc = escImg.GetComponent<Button>();
        btnSim = simpleImg.GetComponent<Button>();
        btnDif = difImg.GetComponent<Button>();
        btnHell = hellImg.GetComponent<Button>();

        btnEsc.onClick.RemoveAllListeners();
        btnSim.onClick.RemoveAllListeners();
        btnDif.onClick.RemoveAllListeners();
        btnHell.onClick.RemoveAllListeners();

        btnEsc.onClick.AddListener(
            delegate()
            {
                btnEscClick(escImg);
            });
        btnSim.onClick.AddListener(
            delegate()
            {
                btnSimClick(simpleImg);
            });
        btnDif.onClick.AddListener(
            delegate ()
            {
                btnDifClick(difImg);
            });
        btnHell.onClick.AddListener(
            delegate ()
            {
                btnHellClick(hellImg);
            });

    }

    private void btnHellClick(GameObject hellImg)
    {
        throw new NotImplementedException();
    }

    private void btnDifClick(GameObject difImg)
    {
        throw new NotImplementedException();
    }

    private void btnSimClick(GameObject simpleImg)
    {
        SceneManager.LoadScene("myscene");
    }

    private void btnEscClick(GameObject escImg)
    {
        SceneManager.LoadScene("start");
    }

    // Update is called once per frame
    void Update () {
		
	}
}
