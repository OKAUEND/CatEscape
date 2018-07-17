using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleControl : MonoBehaviour {
    GameObject Player;

    // Use this for initialization
    void Start()
    {
        this.Player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -0.1f, 0);

        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        Vector2 p1 = transform.position;
        Vector2 p2 = this.Player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;
        float r2 = 0.8f;

        if (d < r1 + r2)
        {
            Destroy(gameObject);
            GameObject Director = GameObject.Find("GameDirector");
            Director.GetComponent<GameDirector>().HealHP();
        }

    }
}
