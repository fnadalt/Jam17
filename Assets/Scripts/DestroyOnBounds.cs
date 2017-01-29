using UnityEngine;
using System.Collections;

public class DestroyOnBounds : MonoBehaviour 
{

	void OnTriggerEnter2D (Collider2D coll) 
	{
		//Se destruye el otro objeto de la colisión
		Destroy (coll.gameObject);
	}
}
