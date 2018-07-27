using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq ;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class manger : MonoBehaviour {
public facts[] q ;
private static List<facts> unansered ;
private facts onscreen;
public Text factA;
    public Text factB;
    public Text factC;
    public Text factD;
	 public Text qustion;
	 	 public int anser;
		  public int user;

    public Text iright;
	 public Text iwrong;
	 public Animator am;
public bool done;
public static int one = 1; 
public float two = 0.5f; 
public string lastq = "a";
public int type;
public bool x;
public bool plus;

public bool mins;
public bool all;

public bool devtion;

//public int last;
public int frist;

public int secend;
public decimal prdect;

public int min;
public int max;
public float leftover;
public bool lrft;
public bool dev;
public bool l;
 public float devmin;
	public	float devmax;
public string remander = "remander";
public int last;
public static float time;
public static float qa;
public static int userhasanersed = 0 ;
public static bool anserd = false;
public static int correct;
public static int wrong;
		 public float qaa;
			public Text qaaa;
			public static string timelast;
			public AudioSource ca;
					public AudioSource wa;
					public int right ;
					public int wrongs;
	public int i;
	public int updates = 0;
	public static float allqa;
	public  float seenallqa;
	public static  float didnotfish;
	public float seendidnotfish;
	public static float qaall;
void Start (){
		
	correct = 0;
	wrong = 0;
	ca = don.cas ;
	wa = don.was;
	qaa = start.qa;
	qa = start.qa;
	allqa = qaa;
	qaall = qa;

if (unansered == null || unansered.Count == 0 ){



	unansered = q.ToList<facts>();
}
getrandomfact();


}
void getrandomfact(){

	
	int last = UnityEngine.Random.Range(1,5);

done = false;
	 i =  UnityEngine.Random.Range(0, unansered.Count);
	
		int frist = UnityEngine.Random.Range(0,13);
			
			int secend = UnityEngine.Random.Range(1,12);
	
	
 
      
	
			if(x){ prdect = frist * secend;

			if (qustion.text != frist.ToString () + " X " + secend.ToString ()) {
				qustion.text = frist.ToString () + " X " + secend.ToString ();
			} 
			}
			if(plus){  prdect = frist + secend;
			
			if (qustion.text != frist.ToString () + " + " + secend.ToString ()) {
				qustion.text = frist.ToString () + " + " + secend.ToString ();
			} 
		}
			if(mins){ 
				prdect = frist - secend;

			if (qustion.text != frist.ToString () + " - " + secend.ToString ()) {
				qustion.text = frist.ToString () + " - " + secend.ToString ();
			} 
			}
			if(devtion){prdect =  decimal.Divide(frist, secend);
prdect = decimal.Round(prdect, 2);

			if (qustion.text != frist.ToString () + " / " + secend.ToString ()) {
				qustion.text = frist.ToString () + " / " + secend.ToString ();
			} 


		
			}if(all){ prdect = frist * secend;
		
			}
			
			

	onscreen = unansered [i];
   unansered.RemoveAt (i);
	
	  
	if (lastq == onscreen.fact){

getrandomfact();

	}
		if(x){ prdect = frist * secend;



			Debug.Log (  onscreen.factA +" factA ");	
			Debug.Log (onscreen.factB +" factB ");
			Debug.Log ( onscreen.factC +" factC ");
			Debug.Log ( onscreen.factD +" factD");
			Debug.Log ( frist +" X "+ secend + "=" + prdect );


		}
		if(plus){  prdect = frist + secend;


			Debug.Log (  onscreen.factA +" factA ");	
			Debug.Log (onscreen.factB +" factB ");
			Debug.Log ( onscreen.factC +" factC ");
			Debug.Log ( onscreen.factD +" factD");
			Debug.Log ( frist +" + "+ secend + "="  + prdect );

		}
		if(mins){ 
			prdect = frist - secend;


			Debug.Log (  onscreen.factA +" factA ");	
			Debug.Log (onscreen.factB +" factB ");
			Debug.Log ( onscreen.factC +" factC ");
			Debug.Log ( onscreen.factD +" factD");
			Debug.Log ( frist +" - "+ secend + "="  + prdect );


		}
		if(devtion){prdect =  decimal.Divide(frist, secend);
			prdect = decimal.Round(prdect, 2);


			Debug.Log (  onscreen.factA +" factA ");	
			Debug.Log (onscreen.factB +" factB ");
			Debug.Log ( onscreen.factC +" factC ");
			Debug.Log ( onscreen.factD +" factD");




		}
	if (devtion ){
if (last == 1){
	float a = UnityEngine.Random.Range(devmin,devmax);
	 a = (float)(Math.Truncate((double)a*100.0) / 100.0);
onscreen.factA =  a.ToString() ;
 
		
 onscreen.factB = UnityEngine.Random.Range(min,max).ToString();
 onscreen.factC = UnityEngine.Random.Range(min,max).ToString();
 onscreen.factD = prdect.ToString();
onscreen.isA = false ;
onscreen.isB = false ;
onscreen.isC = false ;
onscreen.isD = true ;
} 
if (last == 2){
	float b = UnityEngine.Random.Range(devmin,devmax);
	 b = (float)(Math.Truncate((double)b*100.0) / 100.0);
onscreen.factA = prdect.ToString() ;
 onscreen.factB  =  UnityEngine.Random.Range(min,max).ToString();
 onscreen.factC =  b.ToString();
	
 onscreen.factD = UnityEngine.Random.Range(0,11).ToString();
onscreen.isA = true ;
onscreen.isB = false ;
onscreen.isC = false ;
onscreen.isD = false ;
}if (last == 3){
	float c = UnityEngine.Random.Range(devmin,devmax);
	 c = (float)(Math.Truncate((double)c*100.0) / 100.0);
onscreen.factA = UnityEngine.Random.Range(min,max).ToString();
	
 onscreen.factB = UnityEngine.Random.Range(min,max).ToString();
 onscreen.factC =prdect.ToString();
 onscreen.factD = c.ToString();
onscreen.isA = false ;
onscreen.isB = false ;
onscreen.isC = true;
onscreen.isD =false ;
}
if (last == 4){
	float d = UnityEngine.Random.Range(devmin,devmax);
	 d = (float)(Math.Truncate((double)d*100.0) / 100.0);
onscreen.factA =  d.ToString()  ;
 onscreen.factB = prdect.ToString() ;
 onscreen.factC = UnityEngine.Random.Range(min,max).ToString();
 onscreen.factD = UnityEngine.Random.Range(min,max).ToString();
onscreen.isA = false ;
onscreen.isB = true ;
onscreen.isC = false ;
onscreen.isD = false ;
if(onscreen.factA == onscreen.factB||onscreen.factA == onscreen.factC||onscreen.factA == onscreen.factD||onscreen.factB == onscreen.factA||onscreen.factB == onscreen.factC||onscreen.factB == onscreen.factD||onscreen.factC == onscreen.factB||onscreen.factC == onscreen.factD||onscreen.factC == onscreen.factA||onscreen.factD == onscreen.factB||onscreen.factD == onscreen.factC||onscreen.factD == onscreen.factA){
onscreen.factA =  d.ToString()  ;
 onscreen.factB = prdect.ToString() ;
 onscreen.factC = UnityEngine.Random.Range(min,max).ToString();
 onscreen.factD = UnityEngine.Random.Range(min,max).ToString();
	
}
}

	}
if (!devtion){

if (last == 1){
	
			onscreen.factA =  UnityEngine.Random.Range(min,max).ToString();
 
		
 onscreen.factB = UnityEngine.Random.Range(min,max).ToString();
 onscreen.factC = UnityEngine.Random.Range(min,max).ToString();
 onscreen.factD = prdect.ToString();
onscreen.isA = false ;
onscreen.isB = false ;
onscreen.isC = false ;
onscreen.isD = true ;
if(onscreen.factA == onscreen.factB||onscreen.factA == onscreen.factC||onscreen.factA == onscreen.factD||onscreen.factB == onscreen.factA||onscreen.factB == onscreen.factC||onscreen.factB == onscreen.factD||onscreen.factC == onscreen.factB||onscreen.factC == onscreen.factD||onscreen.factC == onscreen.factA||onscreen.factD == onscreen.factB||onscreen.factD == onscreen.factC||onscreen.factD == onscreen.factA){
	
onscreen.factA =  UnityEngine.Random.Range(min,max).ToString();
 
		
 onscreen.factB = UnityEngine.Random.Range(min,max).ToString();
 onscreen.factC = UnityEngine.Random.Range(min,max).ToString();
 onscreen.factD = prdect.ToString();
}
} 
if (last == 2){

onscreen.factA = prdect.ToString() ;
 onscreen.factB  =  UnityEngine.Random.Range(min,max).ToString();
 onscreen.factC = UnityEngine.Random.Range(min,max).ToString();
	
 onscreen.factD =  UnityEngine.Random.Range(0,11).ToString();
onscreen.isA = true ;
onscreen.isB = false ;
onscreen.isC = false ;
onscreen.isD = false ;
if(onscreen.factA == onscreen.factB||onscreen.factA == onscreen.factC||onscreen.factA == onscreen.factD||onscreen.factB == onscreen.factA||onscreen.factB == onscreen.factC||onscreen.factB == onscreen.factD||onscreen.factC == onscreen.factB||onscreen.factC == onscreen.factD||onscreen.factC == onscreen.factA||onscreen.factD == onscreen.factB||onscreen.factD == onscreen.factC||onscreen.factD == onscreen.factA){
onscreen.factA = prdect.ToString() ;
 onscreen.factB  =  UnityEngine.Random.Range(min,max).ToString();
 onscreen.factC = UnityEngine.Random.Range(min,max).ToString();
	
 onscreen.factD =  UnityEngine.Random.Range(0,11).ToString();
}
}if (last == 3){

onscreen.factA = UnityEngine.Random.Range(min,max).ToString();
	
 onscreen.factB = UnityEngine.Random.Range(min,max).ToString();
 onscreen.factC =prdect.ToString() ;
 onscreen.factD =UnityEngine.Random.Range(min,max).ToString();
onscreen.isA = false ;
onscreen.isB = false ;
onscreen.isC = true;
onscreen.isD =false ;
if(onscreen.factA == onscreen.factB||onscreen.factA == onscreen.factC||onscreen.factA == onscreen.factD||onscreen.factB == onscreen.factA||onscreen.factB == onscreen.factC||onscreen.factB == onscreen.factD||onscreen.factC == onscreen.factB||onscreen.factC == onscreen.factD||onscreen.factC == onscreen.factA||onscreen.factD == onscreen.factB||onscreen.factD == onscreen.factC||onscreen.factD == onscreen.factA){
onscreen.factA = UnityEngine.Random.Range(min,max).ToString();
	
 onscreen.factB = UnityEngine.Random.Range(min,max).ToString();
 onscreen.factC =prdect.ToString() ;
 onscreen.factD =UnityEngine.Random.Range(min,max).ToString();
}
}
if (last == 4){

onscreen.factA =  UnityEngine.Random.Range(min,max).ToString();
 onscreen.factB = prdect.ToString() ;
 onscreen.factC = UnityEngine.Random.Range(min,max).ToString();
 onscreen.factD = UnityEngine.Random.Range(min,max).ToString();
onscreen.isA = false ;
onscreen.isB = true ;
onscreen.isC = false ;
onscreen.isD = false ;
if(onscreen.factA == onscreen.factB||onscreen.factA == onscreen.factC||onscreen.factA == onscreen.factD||onscreen.factB == onscreen.factA||onscreen.factB == onscreen.factC||onscreen.factB == onscreen.factD||onscreen.factC == onscreen.factB||onscreen.factC == onscreen.factD||onscreen.factC == onscreen.factA||onscreen.factD == onscreen.factB||onscreen.factD == onscreen.factC||onscreen.factD == onscreen.factA){
onscreen.factA =  UnityEngine.Random.Range(min,max).ToString();
 onscreen.factB = prdect.ToString();
 onscreen.factC = UnityEngine.Random.Range(min,max).ToString();
 onscreen.factD = UnityEngine.Random.Range(min,max).ToString();
}
}

}


	factA.text = onscreen.factA;
	factB.text = onscreen.factB;
	factC.text = onscreen.factC;
	factD.text = onscreen.factD;
	
 if(x){ onscreen.fact = frist.ToString()+" X "+ secend.ToString();
		
			}
			if(plus){ onscreen.fact = frist.ToString()+" + "+ secend.ToString();
		 
			}
			if(mins){ onscreen.fact = frist.ToString()+" - "+ secend.ToString();
	
			}
			if(devtion){ onscreen.fact = frist.ToString()+" / "+ secend.ToString();
			
			}if(all){ onscreen.fact = frist.ToString()+" X "+ secend.ToString() ;
		
			}

qustion.text = onscreen.fact;
lastq = onscreen.fact;
	
	
	if(onscreen.isA == true){
	anser = 1;

	}
	if(onscreen.isB == true){

anser = 2;

	}
	if(onscreen.isC == true){

anser = 3;

	}
	if(onscreen.isD == true){

anser = 4;

	}
	

	
		check ();
}

public void Update(){
		
		seenallqa = allqa;
		didnotfish = qaa;
		seendidnotfish = didnotfish;

qaaa.text = qaa.ToString();
Invoke("f",one +2);
	
	if(frist > secend){


		
getrandomfact();
	
			
			}
			

if(done == false && user != 0){
	  if(user == anser){

	    Invoke("r",two);
	done = true;
	 
	 user = 0;
   }else{
 Invoke("w",two );
 done = true;

  user = 0;

   }
   if(unansered.Count== 0){
	    
  unansered = q.ToList<facts>();


	} 

	}
	
}
public void a(){
user = 1;
am.SetTrigger("a");

}

public void w(){


 iwrong.text = " incorrect:(";
wa.Play();
	userhasanersed = userhasanersed + 1 ;
	wrong = wrong + 1;

qaa = qaa - 1;
		anserd = true ;
Invoke("w2",one);
}
public void w2(){

wa.Stop();
 iwrong.text = "";
		anserd = false ;
 getrandomfact();
}
public void r(){

iright.text = "correct!:)";
ca.Play();
	userhasanersed = userhasanersed + 1 ;
	correct = correct + 1;
		
qaa = qaa - 1 ;
	anserd = true ;
Invoke("r2",one);
}
public void r2(){
ca.Stop();
iright.text = "";
	anserd = false;
getrandomfact();

}
public void b(){
user = 2;
am.SetTrigger("b");
}
public void c(){
user = 3;
am.SetTrigger("c");
}
public void d(){
user = 4;
am.SetTrigger("d");

}
void f (){
				if(qaa == 0){
						if(start.timeison == true){
timelast = timer.timeleft.ToString() + ":" + timer.sec;
	} if(start.timeison == false){
timelast = "notimer";
	}
wrong += Convert.ToInt32(Math.Ceiling(qaa));
SceneManager.LoadScene("done");
}
}
	void check (){
		if (factA.text != onscreen.factA ||
			factB.text != onscreen.factB ||
			factC.text != onscreen.factC ||
			factD.text != onscreen.factD) {
			getrandomfact ();
			factA.text = onscreen.factA;
			factB.text = onscreen.factB;
			factC.text = onscreen.factC;
			factD.text = onscreen.factD;
			check ();

		}
		if (qustion.text != onscreen.fact) {

			//onscreen = unansered [i];
			getrandomfact ();



		} else {
			int i = 0;
			if (i > 1) {
				check ();
				i++;
			}
		}
		if (factA.text != onscreen.factA ||
			factB.text != onscreen.factB ||
			factC.text != onscreen.factC ||
			factD.text != onscreen.factD) {
			getrandomfact ();
			factA.text = onscreen.factA;
			factB.text = onscreen.factB;
			factC.text = onscreen.factC;
			factD.text = onscreen.factD;
			check ();

		}

	

	}
}
	


