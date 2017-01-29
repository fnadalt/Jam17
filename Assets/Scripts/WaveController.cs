using UnityEngine;
using System.Collections;


public class WaveController : MonoBehaviour 
{
	private Vector3 mousePos; //Posicion real del mouse al clickear
	private Vector2 mousePos2D; //Posicion 2D del mouse al clickear
	private Vector2 force;  //Dirección de la fuerza
	public float forceSpeed = 5.0f; //Multiplicador de la fuerza
	public ForceMode2D forceMode; //ForceMode del objeto
	private Rigidbody2D rb2D; //Rigidbody del objeto
	private float dist;  //Distancia entre el click y la burbuja
	public float delayMultiplier = 1.0f;


	// Use this for initialization
	void Start () 
	{
		rb2D = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		if (ClicksAvailable.canTap)
		{
			if (Input.GetMouseButtonDown (0)) 
			{
				//Se utiliza ScreenToWorldPoint para traducir las coordenadas del mouse a globales
				mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
				mousePos.z = 0;

				//Se calcula la distancia entre el objeto y el click
				dist = Vector3.Distance (mousePos, transform.position);

				//Se traducen las coordenadas a un Vector2
				mousePos2D.x = mousePos.x;
				mousePos2D.y = mousePos.y;

				//Se de una dirección opuesta a la del click
				force = new Vector2 (transform.position.x - mousePos2D.x, transform.position.y - mousePos2D.y);

				//Usamos invoke para generar la fuerza con un delay proporcional a la distancia
				Invoke ("DistanceDelay", dist * delayMultiplier);
			}


		}	
	}

	void DistanceDelay()
	{
		//Se genera una fuerza proporcional a la distancia entre el click y el objeto
		rb2D.AddForce (force * forceSpeed / (dist * dist), forceMode);
	}

}
