using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownText : MonoBehaviour {

    private float timeleft;
    private int i;


    // Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        timeleft -= Time.deltaTime;
        if(timeleft <= 0.0 && GameManger.Instance.startCount >= 0)
        {
            timeleft = 1.0f;
            if (GameManger.Instance.startCount == 0)
            {
                GetComponent<Text>().enabled = false;
            }

            this.GetComponent<Text>().text = GameManger.Instance.startCount.ToString();
            GameManger.Instance.startCount--;
        }
	}
}
