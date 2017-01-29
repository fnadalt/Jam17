using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ClicksAvailable : MonoBehaviour 
{

	static public bool canTap; //Un booleano global que indica si el jugador tiene click disponibles
	public int totalAvailableClicks = 4; //Número de click disponibles totales
	private int availableClicks = 0;  //Número de click disponibles actuales
	public float recoveryTime = 3.0f; //Tiempo de recuperación de los clicks
	private float realRecoveryTime = 0.0f; //Tiempo real de recuperación
	public GameObject splash; //Un prefab para la animación de onda

	public GameObject firstTap;
	public GameObject secondTap;
	public GameObject thirdTap;
	public GameObject fourthTap;


	// Use this for initialization
	void Start () 
	{
		realRecoveryTime = recoveryTime; //Se setea el tiempo de recuperación
		canTap = true;	
		availableClicks = totalAvailableClicks; //Se setea el número de golpes disponibles
	}
	
	// Update is called once per frame
	void Update () 
	{
		//En caso de hacer click y tener golpes disponibles, se resta uno al número
		//de golpes disponibles total y se instancia la animación donde se hizo click
		if (Input.GetMouseButtonDown (0) && availableClicks > 0) 
		{
			availableClicks--;
			Vector3 mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			mousePos.z = 0;
			Instantiate (splash, mousePos, Quaternion.identity);
		}

		//En caso de no estar todos los clicks disponibles se resta el tiempo de recuperación
		if (availableClicks < 4) 
			realRecoveryTime -= Time.deltaTime;

		//En caso de llegar el tiempo de recuperación a 0 se suma uno al número de golpes disponibles
		//y se resetea el tiempo de recuperación
		if (realRecoveryTime <= 0) 
		{
			availableClicks++;
			realRecoveryTime = recoveryTime;
		}

		//En caso de tener 0 goples disponibles no se puede golpear
		if (availableClicks <= 0)
			canTap = false;
		else
			canTap = true;

		//Se activan los diferentes indicadores correspondientes a los golpes disponibles
		//según el número indicado por availableClicks
		if (availableClicks == 3) 
		{
			fourthTap.SetActive (false);
			thirdTap.SetActive (true);
			secondTap.SetActive (true);
			firstTap.SetActive (true);
		}
		else if (availableClicks == 2) 
		{
			fourthTap.SetActive (false);
			thirdTap.SetActive (false);
			secondTap.SetActive (true);
			firstTap.SetActive (true);
		} 
		else if (availableClicks == 1) 
		{
			fourthTap.SetActive (false);
			thirdTap.SetActive (false);
			secondTap.SetActive (false);
			firstTap.SetActive (true);
		} 
		else if (availableClicks == 0) 
		{
			fourthTap.SetActive (false);
			thirdTap.SetActive (false);
			secondTap.SetActive (false);
			firstTap.SetActive (false);
		}
	
	}
}
