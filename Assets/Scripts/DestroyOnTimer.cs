using UnityEngine;
using System.Collections;

public class DestroyOnTimer : MonoBehaviour 
{

	public float timer = 3.0f;  //Un número para el tiempo de destrucción

	// Update is called once per frame
	void Update () 
	{
		//Se resta el tiempo al timer
		timer -= Time.deltaTime;

		//En caso de llegar a 0 se destruye el objeto
		if (timer <= 0)
			Destroy (gameObject);
	
	}
}
