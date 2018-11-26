using System;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;


public class GameController: MonoBehaviour
{
	public static List<Question> questions;	
	public static IDictionary<Question, String> questionResultMap;
	public int QUESTION_COUNT = 1;
	public static int resultCount;
	public Button startButton;

	public GameController ()
	{
		//Read questions from file and initialize
	}

	public List<Question> l1Questions;
	public List<Question> l2Questions;

	private void loadQuestions()
	{
		questions = new List<Question> ();
		//Read some files and
		List<String> choices = new List<String>();
		choices.Add ("8");
		choices.Add ("10");
		choices.Add ("9");
		choices.Add ("11");
		List<String> ans = new List<String>();
		ans.Add ("8");
		questions.Add(new Question("3 + 5", choices, ans , "A"));


		List<String> choices2 = new List<String>();
		choices2.Add ("4");
		choices2.Add ("5");
		choices2.Add ("9");
		choices2.Add ("11");
		List<String> ans2 = new List<String>();
		ans2.Add ("4");
		ans2.Add ("5");
		questions.Add(new Question("Sum of two resulting 10 - 1", choices2, ans2 , "B"));



		startButton.onClick.AddListener(startButtonClicked);

		questionResultMap = new Dictionary<Question, String> ();
	}


	private void EnableStartBtn()
	{
		GameObject.Find ("Canvas").SetActive(true);
	}

	void Start()
	{
		resultCount = 0;
		if (questions == null) {
			loadQuestions();
		}
		else if (questions.Count == QUESTION_COUNT) {
			//Press start game to start	

		} else if (questions.Count != 0) {
			changeScene ();

		} else if (questions.Count == 0 && questionResultMap.Count == QUESTION_COUNT) {
			//Show the results and make adaptations to change to pervious questions
			//Once the questions are loaded 
			makeAdaptations();
		} else {
			//Check what case will come here
		}

	}

	public void makeAdaptations()
	{
		//Change the questions based on previous results by looking at questions result map.
		loadQuestions();
	}

	public void startButtonClicked()
	{
		changeScene ();	
	}

	public static Question getQuestion()
	{
		Question question = questions [0];
		questions.RemoveAt (0);
		return question;
	}

	public static String getScore()
	{
		return resultCount.ToString ();
	}

	public static void addQuestionResult(Question question, String result)
	{
		questionResultMap.Add (question, result);
		if (result.Equals ("1")) {
			resultCount += 1;
		}

		if (questions.Count != 0) {
			SceneManager.LoadSceneAsync ("Main");
		} else {
			SceneManager.LoadSceneAsync ("ResultScene");
		}

		SceneManager.UnloadSceneAsync ("Main");
	}


	private void changeScene()
	{

		//Start the questions scene
		SceneManager.LoadSceneAsync("Main");
	}
}		

