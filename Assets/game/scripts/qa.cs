using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class qa : MonoBehaviour {

		 public float qaa ;
			public Text qaaa;
	// Use this for initialization
	void Start () {
		qaa = start.qa;
	}
	
	// Update is called once per frame
	void Update () {
qaaa.text = qaa.ToString();
	if(manger.anserd ){
		Invoke("b",manger.one);
		}
		
		if (qaa == 0){
SceneManager.LoadScene("done");
		}
	}
	public void b (){


		if(manger.anserd ){

		qaa = qaa - manger.userhasanersed;
		}
	}
}
