using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour 
{
	public GameObject spawner;  //El objeto a ser instanciado
	public float maxTimer = 3.0f;  
	public float minTimer = 1.0f;  //Tiempos mínimos y máximos de instanciado
	public float minX = 1.0f;
	public float maxX = 3.0f;  //Cordeenadas Y mínimas y máximas de instanciado
	private float realTime = 0.0f;  //El tiempo de instanciado
	private Transform spawnPosition;  //Un transform para el objeto a instanciar

	// Use this for initialization
	void Start () 
	{
		//Se setea el tiempo de instanciado a un número aleatorio entre el max y min
		realTime = Random.Range(minTimer, maxTimer);

		//Se setea el transform
		spawnPosition = gameObject.transform;	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (CountDownTimer.startGame) //En caso de ser momento de comenzar
		{
			//Se resta el tiempo de instanciado
			realTime -= Time.deltaTime;

			//En caso de llegar a 0 el tiempo de instanciado
			if (realTime <= 0) 
			{
				//Se genera una posición aleatoria entre el min y max y se instancia el objeto
				spawnPosition.position = new Vector3 (Random.Range (minX, maxX), transform.position.y, 0);
				Instantiate (spawner, spawnPosition.position, Quaternion.identity);	

				//Se setea nuevamente el tiempo de instanciado
				realTime = Random.Range (minTimer, maxTimer);
			}
		}
	}
}
