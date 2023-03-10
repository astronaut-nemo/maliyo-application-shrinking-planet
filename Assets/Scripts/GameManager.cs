using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager instance;

	public GameObject gameOverUI;
	public GameObject scoreUI;

	void Awake ()
	{
		instance = this;
	}

	public void EndGame ()
	{
		gameOverUI.SetActive(true);
		scoreUI.SetActive(false);
	}

	public void Restart ()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

}
