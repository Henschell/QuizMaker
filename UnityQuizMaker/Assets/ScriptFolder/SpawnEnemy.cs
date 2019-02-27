using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    GameObject enemies;
    GameObject[] enemys;
    // public GameObject[] wayPoints;
    public WaypointList wayPointsContainer;
    public int maxEnemys;
    public int maxWayPoints;
    private int currentIndex;
    // Use this for initialization
    void Start()
    {
        enemies = new GameObject("enemies");
        enemys = new GameObject[maxEnemys];
        //wayPoints = new GameObject[20];
        currentIndex = 0;
        //  wayPoints = new GameObject[maxWayPoints];
        for (int i = 0; i < enemys.Length; i++)
        {
            currentIndex = i;
            Invoke("Spawn", i * 2f);
            Debug.Log("Spawning");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void Spawn()
    { 
        enemys[currentIndex] = (GameObject)Instantiate(Resources.Load("Enemy"));
        enemys[currentIndex].transform.SetParent(enemies.transform);
        enemys[currentIndex].transform.position = wayPointsContainer.waypoints[0];
    }
}
