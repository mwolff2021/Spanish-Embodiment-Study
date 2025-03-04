using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FruitsChange : MonoBehaviour
{
	public float tscale = 1.0f;

	private GameObject subtitles;
	private TextMeshPro subs = null;
	private GameObject fruits;
	public AudioSource audio;
	public Animator animator;


	void Start()
	{
		fruits = GameObject.Find("Fruits");
		subtitles = GameObject.Find("Subtitles");
		subs = subtitles.GetComponent<TextMeshPro>();
		audio = GameObject.Find("Instructor").GetComponent<AudioSource>();
		animator = GameObject.Find("Instructor").GetComponent<Animator>();

		StartCoroutine(fruitScript());
	}

	public void ToggleAnimationAndAudio()
	{
		if (audio.isPlaying)
		{
			audio.Pause();
			animator.speed = 0;
		}
		else
		{
			audio.Play();
			animator.speed = 1;
		}
	}


	//For the "Repeat after me" video/audio.
	IEnumerator fruitScript()
	{
		//Start Video/Audio


		subs.text = "Manzana";
		fruits.transform.GetChild(0).gameObject.SetActive(true);
		yield return new WaitForSecondsRealtime(6.13f); //5.25
		fruits.transform.GetChild(0).gameObject.SetActive(false);

		fruits.transform.GetChild(1).gameObject.SetActive(true);
		subs.text = "Naranja";
		yield return new WaitForSecondsRealtime(6.11f); //11
		fruits.transform.GetChild(1).gameObject.SetActive(false);

		fruits.transform.GetChild(2).gameObject.SetActive(true);
		subs.text = "Plátano";
		yield return new WaitForSecondsRealtime(6.06f); //16.5
		fruits.transform.GetChild(2).gameObject.SetActive(false);

		fruits.transform.GetChild(3).gameObject.SetActive(true);
		subs.text = "Sandia";
		yield return new WaitForSecondsRealtime(6.80f); //22
		fruits.transform.GetChild(3).gameObject.SetActive(false);

		fruits.transform.GetChild(4).gameObject.SetActive(true);
		subs.text = "Melón";
		yield return new WaitForSecondsRealtime(6.49f); //27
		fruits.transform.GetChild(4).gameObject.SetActive(false);

		fruits.transform.GetChild(5).gameObject.SetActive(true);
		subs.text = "Fresa";
		yield return new WaitForSecondsRealtime(6.40f); //32.75
		fruits.transform.GetChild(5).gameObject.SetActive(false);

		fruits.transform.GetChild(6).gameObject.SetActive(true);
		subs.text = "Cereza";
		yield return new WaitForSecondsRealtime(7.28f); //37.75
		fruits.transform.GetChild(6).gameObject.SetActive(false);

		fruits.transform.GetChild(7).gameObject.SetActive(true);
		subs.text = "Melocotón";
		yield return new WaitForSecondsRealtime(6.55f); //43
		fruits.transform.GetChild(7).gameObject.SetActive(false);

		fruits.transform.GetChild(8).gameObject.SetActive(true);
		subs.text = "Piña";
		yield return new WaitForSecondsRealtime(6.34f); //48
		fruits.transform.GetChild(8).gameObject.SetActive(false);

		fruits.transform.GetChild(9).gameObject.SetActive(true);
		subs.text = "Pera";
		yield return new WaitForSecondsRealtime(6.76f); //53.5
		fruits.transform.GetChild(9).gameObject.SetActive(false);
		subs.text = "";

		fruits.transform.GetChild(0).gameObject.SetActive(true);
		subs.text = "";
		//subs.text = "¿Qué es?";
		yield return new WaitForSecondsRealtime(5.39f);
		ToggleAnimationAndAudio();
		yield return new WaitForSecondsRealtime(2.0f);
		ToggleAnimationAndAudio();//4
		//subs.text = "Es una manzana.";
		subs.text = "Manzana";
		yield return new WaitForSecondsRealtime(2.66f); //7.5
		fruits.transform.GetChild(0).gameObject.SetActive(false);

		fruits.transform.GetChild(5).gameObject.SetActive(true);
		subs.text = "";
		//subs.text = "¿Qué es?";
		yield return new WaitForSecondsRealtime(4.45f);
		ToggleAnimationAndAudio();
		yield return new WaitForSecondsRealtime(2.0f);
		ToggleAnimationAndAudio();//10.75
		//subs.text = "Es una fresa.";
		subs.text = "Fresa";
		yield return new WaitForSecondsRealtime(2.43f); //14.75
		fruits.transform.GetChild(5).gameObject.SetActive(false);

		fruits.transform.GetChild(1).gameObject.SetActive(true);
		subs.text = "";
		//subs.text = "¿Qué es?";
		yield return new WaitForSecondsRealtime(4.58f);
		ToggleAnimationAndAudio();
		yield return new WaitForSecondsRealtime(2.0f);
		ToggleAnimationAndAudio();
		//subs.text = "Es una naranja.";
		subs.text = "Naranja";
		yield return new WaitForSecondsRealtime(2.67f); //20.75
		fruits.transform.GetChild(1).gameObject.SetActive(false);

		fruits.transform.GetChild(3).gameObject.SetActive(true);
		subs.text = "";
		//subs.text = "¿Qué es?";
		yield return new WaitForSecondsRealtime(4.62f); //23
		ToggleAnimationAndAudio();
		yield return new WaitForSecondsRealtime(2.0f);
		ToggleAnimationAndAudio();                                      
		//subs.text = "Es una sandia.";
		subs.text = "Sandia"; 
		yield return new WaitForSecondsRealtime(2.71f); //26
		fruits.transform.GetChild(3).gameObject.SetActive(false);

		fruits.transform.GetChild(2).gameObject.SetActive(true);
		//subs.text = "¿Qué es?";
		subs.text = ""; 
		yield return new WaitForSecondsRealtime(4.16f);
		ToggleAnimationAndAudio();
		yield return new WaitForSecondsRealtime(2.0f);
		ToggleAnimationAndAudio();//28
		//subs.text = "Es un plátano.";
		subs.text = "Plátano"; 
		yield return new WaitForSecondsRealtime(3.0f); //31
		fruits.transform.GetChild(2).gameObject.SetActive(false);

		subs.text = "";
	}
}
