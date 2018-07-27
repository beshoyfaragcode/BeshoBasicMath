using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class timer : MonoBehaviour {

	public static int timeleft;
		public float min = start.timea;
			public static int sec = 60 ;
		public float qa ;
		public bool ab;
	public  Text timetext ;
	public bool notimer = false;
	public float TLR ;
		public float extra ;
				public float dev ;
			public int	timeallsec = start.timea ;
	void Start () {
		timeallsec = start.timea ;
	if(start.timeison == true){
notimer = false;
	} if(start.timeison == false){
notimer = true;
	}
	
int totalSeconds = timeallsec;
		sec = timeallsec % 60;
		timeleft = timeallsec/ 60;
	
string time = timeleft + ":" + sec;
	


	
	if(!notimer){
	


totalSeconds = timeallsec;
timeleft = totalSeconds / 60;
 sec = totalSeconds % 60;

time = timeleft + ":" + sec;

if(sec == 0){

sec = 60 ;
timeleft = timeleft - 1;
}











	timetext.text = time ;
		Invoke("d",1f) ;	


	} if (notimer){
	timetext.text = "notimer";

	}
		

	}
	
	
	void l () { 

Invoke("a",1f) ;
		
	
			 }
			

	
	public void a(){



		if (timeleft > 0) {
	
			timetext.text = timeleft.ToString() + ":" + sec;
		
			timeleft -= 1;


	}

	}


			void s () { 

Invoke("d",1f) ;
		
	
			 }
			

	
	public void d(){

			timetext.text = timeleft.ToString() + ":" + sec;

		if (sec > 0) {
	

			
			sec -= 1;
			if ( sec == 0 && timeleft > 0) {

a();
sec = 59;
	}
s();
	}
}
public void Update (){
		
	

	if ( timeleft <= 0 && sec <= 0) {

SceneManager.LoadScene("done");
	}
}

}
