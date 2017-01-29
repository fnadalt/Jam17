using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelCanvasController : MonoBehaviour 
{
	//Canvas para los diferentes menues
	private GameObject canvas;
	public GameObject mainCanvas;

	public AudioSource mainAudioSource; //Un AudioSource para los efectos
	public AudioClip buttonSound;  //un clip para el sonido de los botones
	public AudioClip startSound;

	public string firstLevel = "Level0"; //Strings para los niveles a cargar
	public string secondLevel = "Level2";
	public string thirdLevel = "Level3";

	// Use this for initialization
	void Start () 
	{
		canvas = this.gameObject;
	}

	public void LoadFirstLevel()
	{
		//Se reproduce el sonido del botón
		mainAudioSource.clip = startSound;
		mainAudioSource.Play ();

		//Se carga el nivel seleccionado
		SceneManager.LoadScene (firstLevel);
	}

	public void LoadSecondLevel()
	{
		//Se reproduce el sonido del botón
		mainAudioSource.clip = startSound;
		mainAudioSource.Play ();

		//Se carga el nivel seleccionado
		SceneManager.LoadScene (secondLevel);
	}

	public void LoadThirdLevel()
	{
		//Se reproduce el sonido del botón
		mainAudioSource.clip = startSound;
		mainAudioSource.Play ();

		//Se carga el nivel seleccionado
		SceneManager.LoadScene (thirdLevel);
	}


	public void BackButton () 
	{
		//Se reproduce el sonido del botón
		mainAudioSource.clip = buttonSound;
		mainAudioSource.Play ();
		
		//Se vuelve al menú principal
		canvas.SetActive(false);
		mainCanvas.SetActive(true);
	}
}
