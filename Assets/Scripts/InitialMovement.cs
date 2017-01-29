using UnityEngine;
using System.Collections;

public class InitialMovement : MonoBehaviour 
{

	public float force = 10.0f; //Un número para la fuerza
	public float sideForce = 1.0f;
	public ForceMode2D forceMode;
	private Rigidbody2D rb2D;

	// Use this for initialization
	void Start () 
	{
		//Se adjudica el rigidbody del objeto y se le aplica una fuerza inicial
		rb2D = GetComponent<Rigidbody2D> ();
		rb2D.AddForce (new Vector2 (Random.Range(sideForce,-sideForce), force), forceMode);
	}

}
