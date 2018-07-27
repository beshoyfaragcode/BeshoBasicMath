using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fix : MonoBehaviour {
	public static decimal fixqa;
	public float realfixqa;

	// Use this for initialization
	void Start () { 
		fixqa = 0 ;
		fixqa = (decimal)start.qa;
		Debug.Log ("start is "+start.qa);
		Debug.Log ("fix  is "+fixqa);
	}
	void Update(){

		realfixqa = (float)fixqa;
	}
	

}
