using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GodTouches;
using UnityEngine.SceneManagement;

public class GameManger : MonoBehaviour {

    public static GameManger Instance;
    public int startCount;
    public bool viewMenu;
    public bool playerTouch;
    public bool playernowJumping;
    public bool playerFly;
    public bool gameClear;
	// Use this for initialization
	void Start () {
        Instance = this;
        startCount = 3;
        viewMenu = false;
        playerTouch = false;
        gameClear = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (gameClear)
        {
            Debug.Log("Game clear");
            SceneManager.LoadScene("Clear");
            gameClear = false;
        }
	}
}
