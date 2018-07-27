using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class start : MonoBehaviour {
 public Toggle time ;
 public static bool timeison;
  public Slider qustios;
  public static int timea ;
   public  static float qa;
   public Text t;
   public Text q;
   public int timeperqa;
    public  string notimer;
     public int temp;
      public static bool temptime;
	public  static float tooltlqa;
public void Start (){


 
}
   public void Update (){
     qa = qustios.value ;
q.text = qa.ToString() ;
 
   timeison = time.GetComponent<Toggle>().isOn;
  
		timea =  (int)Math.Round(qustios.value) * timeperqa ;


   }
public void a(){


SceneManager.LoadScene("addtion");
}
public void a2(){
timea =  (int)Math.Ceiling(qustios.value) * timeperqa ;

qa = qustios.value ;
		tooltlqa = qa;
 
 if(!timeison){
temptime = false ;
 
   }


SceneManager.LoadScene("main mmu");

}
public void b(){

SceneManager.LoadScene("divtion");

	
}
public void c(){

SceneManager.LoadScene("mlitpltion");
	
}
public void d(){

SceneManager.LoadScene("subtrion");
	
}
}
