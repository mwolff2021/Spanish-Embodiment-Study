using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumbersChange : MonoBehaviour
{
	public float tscale = 1.0f;
	private GameObject subtitles;
	private TextMeshPro subs = null;
	public AudioSource audio;
	public Animator animator;

	void Start()
    {
		subtitles = GameObject.Find("Subtitles");
		subs = subtitles.GetComponent<TextMeshPro>();
		audio = GameObject.Find("Instructor").GetComponent<AudioSource>();
		animator = GameObject.Find("Instructor").GetComponent<Animator>();

		if (subs){
			//StartCoroutine(numberScriptQuestion());
			StartCoroutine(numberScriptRepeat());

		}
		else {
			Debug.Log("Failed to start numbers change; subtitles not found");
		}
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
	IEnumerator numberScriptRepeat(){
		//Start Video/Audio
		//subs.text = "¡Hola!  Vamos a aprender los números. Repita.";
		subs.text = ""; 
		//"Hello! We are going to learn the numbers. Repeat after me."
		yield return new WaitForSecondsRealtime(5.89f); //8.75
		
		subs.text = "Diez\n10";
		yield return new WaitForSecondsRealtime(4.40f); //13.5
		
		subs.text = "Once\n11";
		yield return new WaitForSecondsRealtime(4.32f); //17.75
		
		subs.text = "Doce\n12";
		yield return new WaitForSecondsRealtime(4.65f); //22.25
		
		subs.text = "Trece\n13";
		yield return new WaitForSecondsRealtime(4.58f); //25.5
		
		subs.text = "Catorce\n14";
		yield return new WaitForSecondsRealtime(4.98f); //32
		
		subs.text = "Quince\n15";
		yield return new WaitForSecondsRealtime(4.58f); //36.25
		
		subs.text = "Dieciséis\n16";
		yield return new WaitForSecondsRealtime(5.89f); //42.25
		
		subs.text = "Diecisiete\n17";
		yield return new WaitForSecondsRealtime(6.03f); //48.75
		
		subs.text = "Dieciocho\n18";
		yield return new WaitForSecondsRealtime(5.78f); //54.25
		
		subs.text = "Diecinueve\n19";
		yield return new WaitForSecondsRealtime(4.87f); //59
		
		subs.text = "Veinte\n20";
		yield return new WaitForSecondsRealtime(3.96f); //1:02
														//Note: There's actually eleven words. Not sure if that matters -C

		subs.text = "";
		yield return new WaitForSecondsRealtime(1.00f); 
	
		subs.text = "11";
		//"What shape is this?"
		yield return new WaitForSecondsRealtime(2.38f); //7.5
		ToggleAnimationAndAudio();
		yield return new WaitForSecondsRealtime(2.0f);
		ToggleAnimationAndAudio();
		subs.text = "Once";
		yield return new WaitForSecondsRealtime(3.24f); //10.5
		
		subs.text = "15";
		yield return new WaitForSecondsRealtime(2.72f); //13
		ToggleAnimationAndAudio();
		yield return new WaitForSecondsRealtime(2.0f);
		ToggleAnimationAndAudio();
		subs.text = "Quince";
		yield return new WaitForSecondsRealtime(3.09f); //16.75
		
		subs.text = "13";
		yield return new WaitForSecondsRealtime(3.38f); //19.75
		ToggleAnimationAndAudio();
		yield return new WaitForSecondsRealtime(2.0f);
		ToggleAnimationAndAudio();
		subs.text = "Trece";
		yield return new WaitForSecondsRealtime(3.42f); //23.5
		
		subs.text = "19";
		yield return new WaitForSecondsRealtime(3.12f); //26
		ToggleAnimationAndAudio();
		yield return new WaitForSecondsRealtime(2.0f);
		ToggleAnimationAndAudio();
		subs.text = "Diecinueve";
		yield return new WaitForSecondsRealtime(3.17f); //29.25

		//subs.text = "¿Qué número es?\n16";
		subs.text = "16"; 
		yield return new WaitForSecondsRealtime(3.16f); //32.5
		ToggleAnimationAndAudio();
		yield return new WaitForSecondsRealtime(2.0f);
		ToggleAnimationAndAudio();
		subs.text = "Dieciséis";
		yield return new WaitForSecondsRealtime(3.09f); //35
		
		subs.text = "";
	}
}
