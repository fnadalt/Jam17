using UnityEngine;
using System.Collections;

public class DestroyOnClick : MonoBehaviour 
{
	public GameObject explosion; //Un prefab para la explosión

	public AudioSource mainAudioSource; //Un AudioSource para los efectos
	public AudioClip explosionSound;  //un clip para el sonido de los botones

	void Start()
	{
		//Se adjudica el audioSource del GameManager
		mainAudioSource = GameObject.FindGameObjectWithTag ("SoundEffect").GetComponent<AudioSource> ();
	}

	void OnMouseDown ()
	{
		//Se reproduce el sonido del botón
		mainAudioSource.clip = explosionSound;
		mainAudioSource.Play ();

		//Se instancia una animación de explosión y se destruye el objeto
		Instantiate (explosion, transform.position, Quaternion.identity);
		Destroy (gameObject); 
	}
}
