using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class don : MonoBehaviour {
public AudioSource ca;
public AudioSource wa;
public static AudioSource cas;
	public static AudioSource was;

		public static GameObject my;
		public GameObject me ;
	// Use this for initialization
	void Start () {
my	= 	this.gameObject ;
me = my ;
		cas = ca;
		was = wa;
		DontDestroyOnLoad(this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
