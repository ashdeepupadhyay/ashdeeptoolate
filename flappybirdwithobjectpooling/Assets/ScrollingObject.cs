using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour {

    private Rigidbody2D r2bd;

	// Use this for initialization
	void Start () {
        r2bd = GetComponent<Rigidbody2D>();
        r2bd.velocity = new Vector2(GameController.instance.scrollSpeed,0);
	}
	
	// Update is called once per frame
	void Update () {
		if(GameController.instance.gameOver==true)
        {
            r2bd.velocity = Vector2.zero;
        }
	}
}
