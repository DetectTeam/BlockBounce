using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour 
{


	RaycastHit hit;
	// Update is called once per frame
	void Update () 
	{
		if (Physics.Raycast(transform.position, -Vector3.up, out hit)) {
    	//offsetDistance = hit.distance;
   	 	Debug.DrawLine (transform.position, hit.point, Color.cyan);
 }
	}
}
