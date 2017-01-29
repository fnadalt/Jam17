using UnityEngine;
using System.Collections;

public class DestroyOnCollision : MonoBehaviour 
{

	public GameObject explosion;  //Un prefab para la explosión

	public AudioSource mainAudioSource; //Un AudioSource para los efectos
	public AudioClip explosionSound;  //un clip para el sonido de los botones

	void Start()
	{
		//Se adjudica el audioSource del GameManager
		mainAudioSource = GameObject.FindGameObjectWithTag ("SoundEffect").GetComponent<AudioSource> ();
	}

	void OnCollisionEnter2D (Collision2D coll) 
	{
		    //En caso de no colisionar con las paredes ni con otras burbujas
			if (coll.gameObject.tag != "Constrains" && coll.gameObject.tag != "Bubbles") 
		{
			//Se reproduce el sonido del botón
			mainAudioSource.clip = explosionSound;
			mainAudioSource.Play ();

				//Se instancia una animación de explosión y se destruye el objeto
				Instantiate (explosion, transform.position, Quaternion.identity);
				Destroy (gameObject); 
		}	
	}
}
