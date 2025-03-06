using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LessonController : MonoBehaviour
{
	private Renderer r;
	private Material m; 
	private GameObject subtitles;
	private TextMeshPro subs = null;
	private GameObject instructor, colors, fruits, shapes;
	private AudioSource audio;
	private Animator animator;
	public int lesson;
	Color32 pink = new Color32(255, 93, 143, 255);
	Color32 brown = new Color32(95, 52, 35, 255);
	Color32 orange = new Color32(216, 83, 0, 255);


	void Start()
    {
       
		subtitles = GameObject.Find("Subtitles");
		instructor = GameObject.Find("Instructor");
		instructor.SetActive(false);
		audio = instructor.GetComponent<AudioSource>();
		animator = instructor.GetComponent<Animator>();
		animator.speed = 0;
		audio.Pause();
		shapes = GameObject.Find("ShapesDisplay");
		shapes.SetActive(false);
		colors = GameObject.Find("ColorsDisplay");
		colors.SetActive(false);
		fruits = GameObject.Find("FruitsDisplay");
		fruits.SetActive(false);

		subs = subtitles.GetComponent<TextMeshPro>();
		subs.text = ""; 
		switch (lesson)
		{
			case 1: //shapes
				shapes.SetActive(true); 
				r = shapes.GetComponent<Renderer>();
				StartCoroutine(shapeScript()); 
				break;
			case 2: //colors
				colors.SetActive(true); 
				r = colors.GetComponent<Renderer>();
				m = r.material;
				StartCoroutine(colorScript()); 
				break;
			case 3: //fruits
				fruits.SetActive(true);
				StartCoroutine(fruitScript());
				break; 
			case 4: //numbers
				StartCoroutine(numberScript());
				break;
			default:
				break; 
		}
	}

	IEnumerator CalibrationStep()
    {
		
		subs.text = "Put your hands in front of you";
		yield return new WaitForSecondsRealtime(5.0f);

		subs.text = "Put your hands out to the side";
		yield return new WaitForSecondsRealtime(5.0f);

		subs.text = "Raise your hands";
		yield return new WaitForSecondsRealtime(5.0f);

		subs.text = "Put your hands at your sides";
		yield return new WaitForSecondsRealtime(5.0f);

		subs.text = "Look left";
		yield return new WaitForSecondsRealtime(5.0f);

		subs.text = "Look right";
		yield return new WaitForSecondsRealtime(5.0f);

		subs.text = "The lesson will begin shortly";
		yield return new WaitForSecondsRealtime(30.0f);


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

	void changeShape(string shapename){
		r.material.mainTexture = Resources.Load(shapename, typeof(Texture)) as Texture;
	}

	IEnumerator fruitScript()
	{
		yield return StartCoroutine(CalibrationStep());
		instructor.SetActive(true);
		audio.Play();
		animator.speed = 1;
		//yield return StartCoroutine(CalibrationStep()); 
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
	IEnumerator numberScript()
	{
		yield return StartCoroutine(CalibrationStep());
		instructor.SetActive(true); 
		//Start Video/Audio
		//subs.text = "¡Hola!  Vamos a aprender los números. Repita.";
		subs.text = "";
		audio.time = 6.76f;
		audio.Play();
		animator.speed = 1; 
		animator.Play("numeros_2");
		//"Hello! We are going to learn the numbers. Repeat after me."
		//yield return new WaitForSecondsRealtime(6.76f); //8.75

		//subs.text = "Diez\n10";
		//yield return new WaitForSecondsRealtime(4.40f); //13.5

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
	IEnumerator colorScript()
	{
		yield return StartCoroutine(CalibrationStep());
		instructor.SetActive(true); 
		//Start Video/Audio
		//r.enabled = false;
		//subs.text = "¡Hola! Vamos a aprender los colores. Repita.";
		//subs.text = "";
		//"Hello! We are going to learn the colors. Repeat after me."
		//yield return new WaitForSecondsRealtime(6.33f); //7.25
		audio.time = 6.33f;
		animator.speed = 1; 
		audio.Play();
		animator.Play("colores_2", 0, 190);
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
	//For the "Repeat after me" video/audio.
	IEnumerator shapeScript(){
		//Start Video/Audio
		yield return StartCoroutine(CalibrationStep());
		r.enabled = false;
		instructor.SetActive(true); 

		subs.text = ""; 
		//subs.text = "Vamos a aprender las formas. Repita.";
		//"We are going to learn the shapes. Repeat after me."
		//yield return new WaitForSecondsRealtime(4.31f ); //5.25
		audio.time = 4.31f;
		audio.Play();
		animator.speed = 1; 
		animator.Play("formas", 0, 129);
		r.enabled = true;
		
		changeShape("rectangle");
		subs.text = "Rectángulo";
		yield return new WaitForSecondsRealtime(5.92f ); //11
		
		changeShape("circle");
		subs.text = "Círculo";
		yield return new WaitForSecondsRealtime(5.33f ); //16.5
		
		changeShape("triangle");
		subs.text = "Triángulo";
		yield return new WaitForSecondsRealtime(5.71f ); //22
		
		changeShape("square");
		subs.text = "Cuadrado";
		yield return new WaitForSecondsRealtime(4.89f ); //27
		
		changeShape("trapezoid");
		subs.text = "Trapecio";
		yield return new WaitForSecondsRealtime(5.51f ); //32.75
		
		changeShape("oval");
		subs.text = "Óvalo";
		yield return new WaitForSecondsRealtime(5.17f ); //37.75
		
		changeShape("rhombus");
		subs.text = "Rombo";
		yield return new WaitForSecondsRealtime(4.89f ); //43
		
		changeShape("heart");
		subs.text = "Corazón";
		yield return new WaitForSecondsRealtime(5.49f ); //48
		
		changeShape("ring");
		subs.text = "Anillo";
		yield return new WaitForSecondsRealtime(5.25f ); //53.5
		
		changeShape("star");
		subs.text = "Estrella";
		yield return new WaitForSecondsRealtime(4.56f ); //59
		
		r.enabled = false;
		subs.text = "";
		yield return new WaitForSecondsRealtime(1.02f);
		r.enabled = true; 
	
		changeShape("circle");
		//subs.text = "¿Qué forma es?";
		//"What shape is this?"
		yield return new WaitForSecondsRealtime(2.00f); //4
		ToggleAnimationAndAudio();
		yield return new WaitForSecondsRealtime(2.0f);
		ToggleAnimationAndAudio();                                              //subs.text = "Es un círculo.";
		subs.text = "Círculo";
		yield return new WaitForSecondsRealtime(3.17f); //7.5
		
		changeShape("rectangle");
		//subs.text = "¿Qué forma es?";
		subs.text = ""; 
		yield return new WaitForSecondsRealtime(3.34f ); //10.75
		ToggleAnimationAndAudio();
		yield return new WaitForSecondsRealtime(2.0f);
		ToggleAnimationAndAudio();                                              //subs.text = "Es un rectángulo.";
		subs.text = "Rectángulo";
		yield return new WaitForSecondsRealtime(4.10f ); //14.75
		
		changeShape("star");
		//subs.text = "¿Qué forma es?";
		subs.text = ""; 
		yield return new WaitForSecondsRealtime(2.98f ); //17.5
		ToggleAnimationAndAudio();
		yield return new WaitForSecondsRealtime(2.0f);
		ToggleAnimationAndAudio();                                               //subs.text = "Es una estrella.";
		subs.text = "Estrella"; 
		yield return new WaitForSecondsRealtime(2.93f ); //20.75
		
		changeShape("rhombus");
		//subs.text = "¿Qué forma es?";
		subs.text = ""; 
		yield return new WaitForSecondsRealtime(2.78f ); //23
		ToggleAnimationAndAudio();
		yield return new WaitForSecondsRealtime(2.0f);
		ToggleAnimationAndAudio();                                               //subs.text = "Es un rombo.";
		subs.text = "Rombo"; 
		yield return new WaitForSecondsRealtime(2.65f ); //26
		
		changeShape("heart");
		//subs.text = "¿Qué forma es?";
		subs.text = ""; 
		yield return new WaitForSecondsRealtime(2.49f ); //28
		ToggleAnimationAndAudio();
		yield return new WaitForSecondsRealtime(2.0f);
		ToggleAnimationAndAudio();                                              //subs.text = "Es un corazón.";
		subs.text = "Corazón"; 
		yield return new WaitForSecondsRealtime(2.11f ); //31
		
		r.enabled = false;
		subs.text = "";
	}
}
