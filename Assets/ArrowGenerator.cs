using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour {

    public GameObject arrowPrefab;
    public GameObject RedarrowPrefab;
    public GameObject Apple;

    private float GameTime = 0;

    float span = 1.0f;
    float delta = 0;

    float RedStart = 10.0f;
    float RedSpan = 0.82f;
    float RedDelta = 0;

    float AppleSpan = 5.2f;
    float AppleDelta = 0;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        GameTime += Time.deltaTime;
        this.delta += Time.deltaTime;
        this.RedDelta += Time.deltaTime;
        this.AppleDelta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            ArrowGenerate(arrowPrefab);
            //GameObject go = Instantiate(arrowPrefab) as GameObject;
            //int px = Random.Range(-6, 7);
            //go.transform.position = new Vector3(px, 7, 0);
        }

        if (GameTime > RedStart && this.RedDelta > this.RedSpan)
        {
            this.RedDelta = 0;
            ArrowGenerate(RedarrowPrefab);
            //GameObject go = Instantiate(RedarrowPrefab) as GameObject;
            //int px = Random.Range(-6, 7);
            //go.transform.position = new Vector3(px, 7, 0);
        }

        if (this.AppleDelta > this.AppleSpan)
        {
            this.AppleDelta = 0;
            ArrowGenerate(Apple);
            //GameObject go = Instantiate(RedarrowPrefab) as GameObject;
            //int px = Random.Range(-6, 7);
            //go.transform.position = new Vector3(px, 7, 0);
        }
    }

    void ArrowGenerate(GameObject ArrowObject)
    {
        GameObject go = Instantiate(ArrowObject) as GameObject;
        int px = Random.Range(-6, 7);
        go.transform.position = new Vector3(px, 7, 0);
    }
}
