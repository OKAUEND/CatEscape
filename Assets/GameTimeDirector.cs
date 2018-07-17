using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameTimeDirector : MonoBehaviour {

    GameObject GameTimeObject;

    float Minute;
    float Second;

    // Use this for initialization
    void Start () {
        this.GameTimeObject = GameObject.Find("GameTime");
        this.Minute = 0;
        this.Second = 0;
	}
	
	// Update is called once per frame
	void Update () {
        Second += Time.deltaTime;
        if(Second > 60)
        {
            Minute++;
            Second = Second - 60;
        }

        GameTimeObject.GetComponent<Text>().text = Minute.ToString("00") + ":" + Second.ToString("00");
	}
}
