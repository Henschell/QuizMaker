using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToWP : MonoBehaviour {

    //public GameObject WP1;
    //public GameObject WP2;
    //public GameObject WP3;
    //public GameObject WP4;
    public int speed = 50;

    void Start ()
    {
    }
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = new Vector3(Mathf.PingPong(Time.time * speed, 1023), transform.position.y, transform.position.x);
    }
}
