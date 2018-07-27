using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class texttoqa : MonoBehaviour {
	public InputField input;
	public Slider qaslider ;
	public float i ;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		i=float.Parse (input.text);
		qaslider.value = i;
	}
}
