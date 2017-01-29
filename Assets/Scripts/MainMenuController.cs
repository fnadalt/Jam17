using UnityEngine;
using System.Collections;

public class MainMenuController : MonoBehaviour 
{
	//Canvas para las diferentes partes del menu
	public GameObject mainCanvas;  
	public GameObject creditCanvas;
	public GameObject levelsCanvas;

	public AudioSource mainAudioSource; //Un AudioSource para los efectos
	public AudioClip buttonSound;  //un clip para el sonido de los botones

	// Use this for initialization
	void Start () 
	{
		//Se setean los valores iniciales
		mainCanvas.SetActive (true);
		creditCanvas.SetActive (false);
		levelsCanvas.SetActive (false);
	}


	public void DisplayLevels ()
	{
		//Se reproduce el sonido del botón
		mainAudioSource.clip = buttonSound;
		mainAudioSource.Play ();

		//Se cambia el canvas por el de los niveles
		mainCanvas.SetActive (false);
		levelsCanvas.SetActive (true);
	}


	public void DisplayCredits () 
	{
		//Se reproduce el sonido del botón
		mainAudioSource.clip = buttonSound;
		mainAudioSource.Play ();

		//Se cambia el canvas por el de los créditos
		mainCanvas.SetActive (false);
		creditCanvas.SetActive (true);	
	}
}
