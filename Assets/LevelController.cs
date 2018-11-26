using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class LevelController : MonoBehaviour {

	public Button levelButton;
	public Button endButton;

	// Use this for initialization
	void Start () {
		levelButton.onClick.AddListener(levelButtonClicked);
		endButton.onClick.AddListener(endButtonClicked);
		GameObject.Find("ScoreText").GetComponent<Text>().text = "Score: " + GameController.getScore();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void endButtonClicked()
	{
		SceneManager.LoadSceneAsync ("GameScene");
		SceneManager.UnloadSceneAsync ("ResultScene");
	}

	public void levelButtonClicked()
	{
	}
}
