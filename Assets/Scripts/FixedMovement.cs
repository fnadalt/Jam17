using UnityEngine;
using System.Collections;

public class FixedMovement : MonoBehaviour 
{
	public float speed = 1.0f; //Velocidad de movimiento
	private Transform trans;  //Transform del objeto

	// Use this for initialization
	void Start () 
	{
		trans = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		//Se mueve al objeto a través del eje Y
		trans.Translate (new Vector3 (0, speed, 0)*Time.deltaTime);

	}
}
