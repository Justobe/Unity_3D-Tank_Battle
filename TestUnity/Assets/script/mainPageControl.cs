using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mainPageControl : MonoBehaviour {

    // Use this for initialization
    GameObject startImg;
    GameObject helpImg;
    //GameObject levelImg;
    GameObject exitImg;

    Button btnStart;
    Button btnHelp;
    //Button btnLevel;
    Button btnExit;

    void Start () {
        startImg = GameObject.Find("start") as GameObject;
        helpImg = GameObject.Find("help") as GameObject;
        //levelImg = GameObject.Find("level") as GameObject;
        exitImg = GameObject.Find("exit") as GameObject;

        btnStart = startImg.GetComponent<Button>();
        btnHelp = helpImg.GetComponent<Button>();
        //btnLevel = levelImg.GetComponent<Button>();
        btnExit = exitImg.GetComponent<Button>();

        btnStart.onClick.RemoveAllListeners();
        btnHelp.onClick.RemoveAllListeners();
        btnExit.onClick.RemoveAllListeners();

        btnStart.onClick.AddListener(
            delegate()
            {
                btnStartClick(startImg);
            });
        btnHelp.onClick.AddListener(
            delegate ()
            {
                btnHelpClick(helpImg);
            });
        btnExit.onClick.AddListener(
                    delegate ()
                    {
                        btnExitClick(exitImg);
                    });
    }

    private void btnExitClick(GameObject exitImg)
    {
        Application.Quit();
    }

    private void btnHelpClick(GameObject helpImg)
    {
        SceneManager.LoadScene("help");
    }

    private void btnStartClick(GameObject gameobj)
    {
        //Application.LoadLevel("level");
        SceneManager.LoadScene("level");
    }

    // Update is called once per frame
    void Update () {
		
	}
}
