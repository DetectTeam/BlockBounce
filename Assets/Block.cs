using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour 
{


	[SerializeField] private bool isSpecialBlock = false;

	[SerializeField] private Color specialBlockColor;
	[SerializeField] private Color originalColor;

	[SerializeField] private Color[] hitColors;


	[SerializeField] private int maxBlockHits = 0;

	private Material material;

	private void Start()
	{
		material = GetComponent<Renderer>().material;

		if( isSpecialBlock )
		{
			originalColor = material.color;
			material.color = specialBlockColor;
		}
	}

	void OnCollisionEnter(Collision collision)
    {
		Debug.Log( collision.collider.name + " landed on me." );
		
		if( isSpecialBlock )
		{
			isSpecialBlock = false;
			material.color = originalColor;
		}
		else
		{
			Debug.Log( maxBlockHits );
			material.color = hitColors[ maxBlockHits ];
			maxBlockHits ++;
		}
		
		
		if( maxBlockHits > 3 )
		{
			Destroy( gameObject );
		}
	}
	
}
