using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour {

	static public float timeLeft = 0.0f;     //Tiempo inicial del contador
	public float respawnTimeLeft = 25f;		//respawn time countdown

	public Text text;

	public float warmUpTime = 5.0f; //Tiempo de espera para comenzar a instanciar objetos
	static public bool startGame;  //Booleano para indicar el momento de comenzar

	public GameObject spawners;  //El empty que contiene los spawners

	public GameObject mainCanvas; //Los Canvas principales y de juego terminado
	public GameObject gameOverCanvas;

	void Start ()
	{
		//Se setean los valores iniciales
		mainCanvas.SetActive(true);
		gameOverCanvas.SetActive(false);
		timeLeft = respawnTimeLeft;
		startGame = false;
	}

	void Update () 
	{
		//En caso de no estar listo para comenzar
		if (!startGame) 
		{
			//Se resta tiempo al contador
			warmUpTime -= Time.deltaTime;

			//Si el contador llega a 0 se setea startGame para comenzar
			if (warmUpTime <= 0)
				startGame = true;
		} 
		else 
		{
			timeLeft -= Time.deltaTime; //Se resta el tiempo del contador

			//En caso de llegar el tiempo a 0
			if (timeLeft <= 0) 
			{
				//Se destruyen los spawners
				Destroy (spawners);

				//Se cambia el Canvas principal por el de juego terminado
				mainCanvas.SetActive (false);
				gameOverCanvas.SetActive (true);
			}
	
			//Se traduce el tiempo restante a un string para la UI
			text.text = "" + (int)timeLeft;
		}
	}
}
