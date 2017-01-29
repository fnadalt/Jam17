using UnityEngine;
using System.Collections;

public class DeactivateCollider : MonoBehaviour 
{

	public string objectToDeactivate = "Bubble"; //Un string para el tag de los objetos a desactivar
	public int points = 0;  //Puntos a sumarse
	public float plusTime = 2.0f;  //Tiempo extra a sumarse

	public AudioSource mainAudioSource; //Un AudioSource para los efectos
	public AudioClip goalSound;  //un clip para el sonido de la meta

	void OnTriggerEnter2D(Collider2D coll)
	{
		//En caso de ser el objeto indicado
		if (coll.gameObject.tag == "Bubbles") 
		{
			//Se suman puntos y tiempo
			Score.scoreCount += points;

			//Se reproduce el sonido del botón
			mainAudioSource.clip = goalSound;
			mainAudioSource.Play ();

			CountDownTimer.timeLeft += plusTime;
			//Se desactiva el collider del objeto
			coll.isTrigger = true;
		}

		//En caso de ser el tag del objeto el indicado
		else if (coll.gameObject.tag == objectToDeactivate) 
		{
			//Se desactiva el collider del objeto
			coll.isTrigger = true;
		}

	}
}
