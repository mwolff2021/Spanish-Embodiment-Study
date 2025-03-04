using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ColorChange : MonoBehaviour
{
	public float tscale = 1.0f;
    private Material m;
	private Renderer r;
	private GameObject subtitles;
	private TextMeshPro subs;
	Color32 pink = new Color32(255, 93, 143, 255);
	Color32 brown = new Color32(95, 52, 35, 255);
	Color32 orange = new Color32(216, 83, 0, 255);
	public AudioSource audio;
	public Animator animator;
	//https://gamedev.stackexchange.com/questions/166226/how-to-play-and-pause-animation

	void Start()
    {
		r = GetComponent<Renderer>();
		m = r.material;
		subtitles = GameObject.Find("Subtitles");
		subs = subtitles.GetComponent<TextMeshPro>();
		audio = GameObject.Find("Instructor").GetComponent<AudioSource>();
		animator = GameObject.Find("Instructor").GetComponent<Animator>(); 
		if (m&&subs){
			//
			StartCoroutine(colorScriptRepeat());
			//StartCoroutine(colorScriptQuestion());
		}
		else {
			Debug.Log("Failed to start color change; material and/or subtitles not found");
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
	IEnumerator colorScriptRepeat(){
		//Start Video/Audio
		r.enabled = false;
		//subs.text = "¡Hola! Vamos a aprender los colores. Repita.";
		subs.text = "";
		//"Hello! We are going to learn the colors. Repeat after me."
		yield return new WaitForSecondsRealtime(6.33f); //7.25
		r.enabled = true;
		
		m.color = Color.red;
		subs.text = "Rojo";
		yield return new WaitForSecondsRealtime(4.76f); //12.25

		m.color = Color.blue;
		subs.text = "Azul";
		yield return new WaitForSecondsRealtime(4.41f); //17
		
		m.color = Color.green;
		subs.text = "Verde";
		yield return new WaitForSecondsRealtime(4.63f); //21.25
		
		m.color = Color.white;
		subs.text = "Blanco";
		yield return new WaitForSecondsRealtime(4.37f); //25.5
		
		m.color = Color.black;
		subs.text = "Negro";
		yield return new WaitForSecondsRealtime(4.23f); //30
		
		m.color = Color.yellow;
		subs.text = "Amarillo";
		yield return new WaitForSecondsRealtime(4.98f); //35

		m.color = orange; 
		subs.text = "Anaranjado";
		yield return new WaitForSecondsRealtime(6.45f); //42
		
		m.color = brown;
		subs.text = "Color café";
		yield return new WaitForSecondsRealtime(5.77f); //47.25
		
		m.color = Color.grey;
		subs.text = "Gris";
		yield return new WaitForSecondsRealtime(4.97f); //52.25
		
		m.color = pink;
		subs.text = "Rosado";
		yield return new WaitForSecondsRealtime(6.23f); //57
		
		//r.enabled = false;

		subs.text = "";
		m.color = pink;
		//subs.text = "¿Qué color es?";
		subs.text = ""; 
		//"What color is this?"
		yield return new WaitForSecondsRealtime(3.27f); //3.25
		ToggleAnimationAndAudio();
		yield return new WaitForSecondsRealtime(2.0f);
		ToggleAnimationAndAudio();
		subs.text = "Rosado";
		yield return new WaitForSecondsRealtime(2.83f); //6.65
		
		m.color = Color.yellow;
		subs.text = ""; 
		//subs.text = "¿Qué color es?";
		yield return new WaitForSecondsRealtime(2.6f); //9.45
		ToggleAnimationAndAudio();
		yield return new WaitForSecondsRealtime(2.0f);
		ToggleAnimationAndAudio();
		subs.text = "Amarillo";
		yield return new WaitForSecondsRealtime(2.94f); //11.25
		
		m.color = brown;
		subs.text = ""; 
		//subs.text = "¿Qué color es?";
		yield return new WaitForSecondsRealtime(2.61f); //14
		ToggleAnimationAndAudio();
		yield return new WaitForSecondsRealtime(2.0f);
		ToggleAnimationAndAudio();
		subs.text = "Color café";
		yield return new WaitForSecondsRealtime(3.05f); //19
		
		m.color = orange;
		subs.text = ""; 
		//subs.text = "¿Qué color es?";
		yield return new WaitForSecondsRealtime(3.28f); //22
		//PauseAnimationAndAudio(); 
		subs.text = "Anaranjado";
		yield return new WaitForSecondsRealtime(3.22f); //25
		
		m.color = Color.blue;
		subs.text = ""; 
		//subs.text = "¿Qué color es?";
		yield return new WaitForSecondsRealtime(2.32f); //27.75
		//PauseAnimationAndAudio(); 
		subs.text = "Azul";
		yield return new WaitForSecondsRealtime(2.25f); //30
		
		r.enabled = false;
		subs.text = "";
	}
}
