using System;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class GameController: MonoBehaviour
{
	public static List<Question> questions;	
	public static IDictionary<Question, String> questionResultMap;
	public int QUESTION_COUNT = 1;
	public GameController ()
	{
		//Read questions from file and initialize
	}
		
	public List<Question> l1Questions;
	public List<Question> l2Questions;

	private void loadQuestions()
	{
		string ques, List<String> choices, string ans, string type
		//Read some files and
		List<String> questions = new Arra
		questions.Add(new Question("3 + 5", ));
	}

	

	private void EnableStartBtn()
	{
		GameObject.Find ("Canvas").SetActive(true);
	}

	void Start()
	{
		if (questions.Count == QUESTION_COUNT) {
			//Press start game to start	
		} else if (questions.Count != 0) {
			changeScene ();
			
		} else if (questions.Count == 0 && questionResultMap.Count == QUESTION_COUNT) {
			//Show the results and make adaptations to change to pervious questions


		} else if (questions.Count == 0) {
			//Loaded for first time and load the questions.
		} else {

		}

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

	public static void addQuestionResult(Question question, String result)
	{
		questionResultMap.Add (question, result);
	}

	private void changeScene()
	{
		
		//Start the questions scene
		SceneManager.LoadSceneAsync("Main");
	}
}		

