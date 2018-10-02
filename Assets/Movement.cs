using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour 
{


	 private float horizontalSpeed = 2.0f;
    private float verticalSpeed = 2.0f;

	private float distance = 0.0f;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown("up"))
        {
            transform.Translate( -1.0f, 0.0f, 0.0f );
        }
		else if( Input.GetKeyDown( "down" ) )
		{
			transform.Translate( 1.0f, 0.0f, 0.0f );
		}
		else if( Input.GetKeyDown( "left" ) )
		{
			transform.Translate( 0.0f, 0.0f, -1.0f );
		}
		else if( Input.GetKeyDown( "right" ) )
		{
			transform.Translate( 0.0f, 0.0f, +1.0f );
		}

	}
}
