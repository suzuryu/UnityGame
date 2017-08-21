using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCanvas : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Canvas>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (GameManger.Instance.viewMenu)
        {
            GetComponent<Canvas>().enabled = true;
        }else
        {
            GetComponent<Canvas>().enabled = false;
        }
	}
}
