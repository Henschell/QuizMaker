using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowWaypoints : MonoBehaviour {

    float speed = 2f;
    GameObject logic;
    List<Vector3> wayPoints;
    SpawnEnemy SpawnScript;
    public bool isWalking;
    int currentWaypoint;

	void Start () {
        currentWaypoint = 0;
        logic = GameObject.Find("Logic");
        SpawnScript = logic.GetComponent<SpawnEnemy>();
        wayPoints = SpawnScript.wayPointsContainer.waypoints;

	}
	
	// Update is called once per frame
	void Update () {
        if (isWalking)
        {
            Vector3 dir = Vector3.MoveTowards(transform.position, wayPoints[currentWaypoint], speed * Time.deltaTime);
            //this.transform.Translate(dir * 2f * Time.deltaTime);
            this.transform.position = dir;
            if (Mathf.Abs(Vector3.Magnitude(this.transform.position - wayPoints[currentWaypoint])) <= 0.02f)
            {
                currentWaypoint++;
                if (currentWaypoint > wayPoints.Count-1)
                {
                    currentWaypoint = 0;
                }
            }
        }
	}
}
