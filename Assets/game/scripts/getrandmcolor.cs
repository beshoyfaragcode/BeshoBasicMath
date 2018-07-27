using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class getrandmcolor : MonoBehaviour {
	public Image test ;
	public Color banner ;
	public Color lbanner ;
	public Image panel;
	public Color main ;
	public Color remain ;

	public float red ;
	public float blue ;
	public  float green;
	public  float alfa;
	public  float redo ;
	public  float blueo ;
	public float greeno;
	public  float redoa ;
	public  float blueoa ;
	public float greenoa;
	public   float  redoab ;
	public   float blueoab ;
	public  float  greenoab;
	public  float redoabc ;
	public   float blueoabc ;
	public  float  greenoabc;
	public  float  min = 0;
	public  float  playermin = 0;
	public int one = 1;

	void Start () {
		if (one == 1) {
			min = Random.Range (80, 255);
			PlayerPrefs.SetFloat ("min", min);
			one++;
		}
		playermin = PlayerPrefs.GetFloat ("min");
		if (playermin == min) {
			min = Random.Range (80, 255);
			PlayerPrefs.SetFloat ("min", min);
		} 

		getcolor (banner,test,lbanner);
		redoab = Random.Range (min, 255);
		blueoab = Random.Range (min, 255);
		greenoab = Random.Range (min, 255);
		redoab = Random.Range (min, redoabc);
		blueoab = Random.Range (min, blueoabc);
		greenoab = Random.Range (min, greenoabc);
		redoa = Random.Range (min, redoab);
		blueoa = Random.Range (min, blueoab);
		greenoa = Random.Range (min, greenoab);
		redo = Random.Range (min, redoa);
		blueo = Random.Range (min, blueoa);
		greeno = Random.Range (min, greenoa);
		red = Random.Range (min, redo);
		blue = Random.Range (min, blueo);
		green = Random.Range (min, greeno);
	
		//beshoy color changer

		main.r = red / 255;
		main.b = blue / 255;
		main.g = green / 255;
		main.a = 1;

		panel.color = main;
		remain = main;
	}
	


	


	
	
	void Update () {
		
		playermin = PlayerPrefs.GetFloat ("min");

}
	void getcolor(Color mycolor ,Image img,Color copycolor ){
		redoab = Random.Range (min, 255);
		blueoab = Random.Range (min, 255);
		greenoab = Random.Range (min, 255);
		redoab = Random.Range (min, redoabc);
		blueoab = Random.Range (min, blueoabc);
		greenoab = Random.Range (min, greenoabc);
		redoa = Random.Range (min, redoab);
		blueoa = Random.Range (min, blueoab);
		greenoa = Random.Range (min, greenoab);
		redo = Random.Range (min, redoa);
		blueo = Random.Range (min, blueoa);
		greeno = Random.Range (min, greenoa);
		red = Random.Range (min, redo);
		blue = Random.Range (min, blueo);
		green = Random.Range (min, greeno);
		if (copycolor == mycolor) {

		}
		//beshoy color changer

		mycolor.r = red / 255;
		mycolor.b = blue / 255;
		mycolor.g = green / 255;
		mycolor.a = 1;

		img.color = mycolor;
		copycolor = mycolor;
	}
		
	}

