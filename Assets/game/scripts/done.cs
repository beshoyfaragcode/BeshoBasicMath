using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class done : MonoBehaviour {
public decimal seenAll = All;
public Text o;
public Text oa;
public Text ob;
public Text oc;
public Text grade;
public string lettergrade;
public GameObject sound ;
	public static decimal qua = fix.fixqa;
	public static decimal max = Convert.ToInt32(Math.Ceiling(qua));



public static int lastc = manger.correct;

	public static int lastw = manger.wrong  ;

	public static decimal All =  fix.fixqa;

public static Decimal b = decimal.Divide( lastc , All);
public decimal percentage = b * 100;
public static int adscount ;
public int editeradcount ;

//float one = 2 * 100;
void Start (){

percentage = Decimal.Round(percentage,2);
sound = don.my ;
}
	void Update () { 

		editeradcount=adscount;
	
		seenAll = All;
		 lastc = manger.correct;
		lastw = manger.wrong ;
		All =	 fix.fixqa;
 b = decimal.Divide( lastc , All);
 percentage = b * 100;
Debug.Log(manger.correct +"+" +"correct");
		Debug.Log(manger.wrong +" +" +"wrong");
		Debug.Log(b+ "= a");
					Debug.Log( percentage + "= %");
		oc.text = percentage.ToString();
		
		o.text = lastc.ToString() + " of " + All.ToString() ;
				oa.text = lastw.ToString();
		if(manger.timelast != null){
						ob.text = manger.timelast.ToString();
		}else{
			ob.text = "you ran out of time";
		}
								
							 makeGrade();
      grade.text = lettergrade ;
}
public void restart (){

Destroy(sound);
	if(adscount > 2 ){

//AdBuddizBinding.RewardedVideo.Fetch();
		//AdBuddizBinding.RewardedVideo.Show();
adscount = 0;

		}
SceneManager.LoadScene("main mmu 1");
}

public void makeGrade () {
ad();
if(percentage == 100 ){
adscount += 1;
         lettergrade = "A+";
								}
									if(percentage >= 93 && percentage < 100 ){
adscount += 1;
         lettergrade = "A";
								}
		if(percentage >= 80 && percentage < 93 ){
adscount += 1;
         lettergrade = "B";
								}
										if(percentage >= 75 && percentage <  80 ){
adscount += 1;
         lettergrade = "C";
								}
										if(percentage >= 65 && percentage < 75 ){
adscount += 1;
         lettergrade = "D";
								}
								if(percentage < 65){
adscount += 1;
									 lettergrade = "F";
								}
}
void ad(){
if(percentage <= 65  ){
          
adscount += 3;


}



}
}
