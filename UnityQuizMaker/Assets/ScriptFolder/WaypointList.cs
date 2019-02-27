using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[CreateAssetMenu(fileName ="WaypointList", order = 1)]
public class WaypointList : MonoBehaviour //ScriptableObject
{
    public List<Vector3> waypoints;

    public void FillWaypoints(List<Vector3> wps)
    {
        waypoints = wps; 
    }

}
