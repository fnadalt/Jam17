using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverController: MonoBehaviour 
{
	public Text text;

	void Update()
	{
		//Mostramos el puntaje al terminar el juego
		text.text = "Tu puntaje: " + Score.scoreCount;
	}

	public void loadLevel() 
	{
		//Carga nuevamente el nivel
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);

	}

	public void quitLevel()
	{
		//Vuelve al menu principal
		SceneManager.LoadScene("MainMenu");
	}
}
