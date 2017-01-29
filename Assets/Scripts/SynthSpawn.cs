using UnityEngine;
using System.Collections;

public class SynthSpawn : MonoBehaviour 
{
	public GameObject spawner;  //El objeto a ser instanciado
	public float maxTimer = 3.0f;  
	public float minTimer = 1.0f;  //Tiempos mínimos y máximos de instanciado
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
		//Se resta el tiempo de instanciado
		realTime -= Time.deltaTime;

		//En caso de llegar a 0 el tiempo de instanciado
		if (realTime <= 0) 
		{
			//Se randomiza el instanciado en los dos costados de la pantalla
			if (Random.value >= 0.5) 
			{
				spawnPosition.position = new Vector3 (1.7f, transform.position.y, 0);
				Instantiate (spawner, spawnPosition.position, spawnPosition.rotation);	
			} 
			else 
			{
				spawnPosition.position = new Vector3 (-1.7f, transform.position.y, 0);
				Instantiate (spawner, spawnPosition.position, spawnPosition.rotation);	
			}
				
			//Se setea nuevamente el tiempo de instanciado
			realTime = Random.Range(minTimer, maxTimer);
		}
	}
}
