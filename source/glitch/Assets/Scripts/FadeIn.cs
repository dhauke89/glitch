using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour {

	public float alphaLevel = 1f;
	public float fadeSpeed;
	public float waitTime;
	
	void Start(){
		GetComponent<Image>().color = new Color (1,1,1, alphaLevel);
	}
	
	void Update(){
		if(alphaLevel >0){
			Invoke("fadeIn", waitTime);
		}
		
	}
	
	void fadeIn(){
		if(alphaLevel > 0){
			alphaLevel -= fadeSpeed * Time.deltaTime;
			
			float newAlphaLevel = Mathf.Clamp(alphaLevel, 0f, 1f);
			
			alphaLevel = newAlphaLevel;
			
			GetComponent<Image>().color = new Color (1,1,1,alphaLevel);
		}else if(alphaLevel == 0){
			Destroy(GetComponent<Image>());
		}
	}
}
