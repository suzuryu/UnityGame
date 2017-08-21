using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTouchButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StartPush()
    {
        if (GameManger.Instance.playernowJumping)
        {
            GameManger.Instance.playerFly = true;
        }
        GameManger.Instance.playerTouch = true;
    }

    public void StopPush()
    {
        GameManger.Instance.playerTouch = false;
    }
}
