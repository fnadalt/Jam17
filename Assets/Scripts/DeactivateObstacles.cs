using UnityEngine;
using System.Collections;

public class DeactivateObstacles : MonoBehaviour 
{
	public string objectToDeactivate = "Obstacle"; //Un string para el tag de los objetos a desactivar

	void OnTriggerEnter2D(Collider2D coll)
	{
		//En caso de ser el objeto el indicado
		if (coll.gameObject.tag == objectToDeactivate) 
		{
			//Se desactiva el collider del objeto
			coll.isTrigger = true;
		}

	}
}
