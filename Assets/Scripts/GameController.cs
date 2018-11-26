using System;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;


public class GameController: MonoBehaviour
{
	public static List<Question> questions;	
	public static IDictionary<Question, String> questionResultMap;
	public int QUESTION_COUNT = 1;
	public static int resultCount;
	public Button startButton;
	public static int level = 1;

	public GameController ()
	{
		//Read questions from file and initialize
	}

	public static List<Question> l1Questions;
	public static List<Question> l2Questions;
	public static List<Question> l3Questions;

	private static void loadQuestions()
	{
		//Initialising Level 1
		l1Questions = new List<Question> ();
		List<String> choices = new List<String>();
		choices.Add ("8");
		choices.Add ("10");
		choices.Add ("9");
		choices.Add ("11");
		List<String> ans = new List<String>();
		ans.Add ("8");
		l1Questions.Add(new Question("3 + 5", choices, ans , "A"));

		List<String> choices2 = new List<String>();
		choices2.Add ("4");
		choices2.Add ("5");
		choices2.Add ("9");
		choices2.Add ("11");
		List<String> ans2 = new List<String>();
		ans2.Add ("9");
		l1Questions.Add(new Question("10 - 1", choices2, ans2 , "A"));

		choices2 = new List<String>();
		choices2.Add ("2");
		choices2.Add ("5");
		choices2.Add ("9");
		choices2.Add ("11");
		ans2 = new List<String>();
		ans2.Add ("2");
		l1Questions.Add(new Question("5-3", choices2, ans2 , "A"));

		choices2 = new List<String>();
		choices2.Add ("-1");
		choices2.Add ("5");
		choices2.Add ("9");
		choices2.Add ("11");
		ans2 = new List<String>();
		ans2.Add ("-1");
		l1Questions.Add(new Question("0-1", choices2, ans2 , "A"));

		choices2 = new List<String>();
		choices2.Add ("2");
		choices2.Add ("-22");
		choices2.Add ("9");
		choices2.Add ("11");
		ans2 = new List<String>();
		ans2.Add ("-22");
		l1Questions.Add(new Question("21-43", choices2, ans2 , "A"));

		choices = new List<String>();
		choices.Add ("-2");
		choices.Add ("10");
		choices.Add ("9");
		choices.Add ("11");
		ans = new List<String>();
		ans.Add ("-2");
		l1Questions.Add(new Question("3 - 5", choices, ans , "A"));

		choices2 = new List<String>();
		choices2.Add ("4");
		choices2.Add ("5");
		choices2.Add ("7");
		choices2.Add ("11");
		ans2 = new List<String>();
		ans2.Add ("7");
		l1Questions.Add(new Question("8 - 1", choices2, ans2 , "A"));

		choices2 = new List<String>();
		choices2.Add ("2");
		choices2.Add ("5");
		choices2.Add ("9");
		choices2.Add ("12");
		ans2 = new List<String>();
		ans2.Add ("12");
		l1Questions.Add(new Question("10 + 2", choices2, ans2 , "A"));

		choices2 = new List<String>();
		choices2.Add ("-1");
		choices2.Add ("5");
		choices2.Add ("9");
		choices2.Add ("-11");
		ans2 = new List<String>();
		ans2.Add ("-11");
		l1Questions.Add(new Question("0-11", choices2, ans2 , "A"));

		choices2 = new List<String>();
		choices2.Add ("2");
		choices2.Add ("-22");
		choices2.Add ("9");
		choices2.Add ("8");
		ans2 = new List<String>();
		ans2.Add ("8");
		l1Questions.Add(new Question("21-13", choices2, ans2 , "A"));
		////////////////////////////////////////////////////////////////////
		/// 
		/// 
		//Initialising Level 2
		l2Questions = new List<Question> ();

		choices = new List<String>();
		choices.Add ("6");
		choices.Add ("2");
		choices.Add ("9");
		choices.Add ("11");
		ans = new List<String>();
		ans.Add ("6");
		ans.Add ("2");
		l2Questions.Add(new Question("Pop two = 3 + 5", choices, ans , "B"));

		choices2 = new List<String>();
		choices2.Add ("4");
		choices2.Add ("5");
		choices2.Add ("8");
		choices2.Add ("11");
		ans2 = new List<String>();
		ans2.Add ("5");
		ans2.Add ("4");
		l2Questions.Add(new Question("Pop two = 10 - 1", choices2, ans2 , "B"));

		choices2 = new List<String>();
		choices2.Add ("0");
		choices2.Add ("5");
		choices2.Add ("2");
		choices2.Add ("11");
		ans2 = new List<String>();
		ans2.Add ("0");
		ans2.Add ("2");
		l2Questions.Add(new Question("Pop two = 5-3", choices2, ans2 , "B"));

		choices2 = new List<String>();
		choices2.Add ("4");
		choices2.Add ("-5");
		choices2.Add ("9");
		choices2.Add ("11");
		ans2 = new List<String>();
		ans2.Add ("-5");
		ans2.Add ("4");
		l2Questions.Add(new Question("Pop two = 0-1", choices2, ans2 , "B"));

		choices2 = new List<String>();
		choices2.Add ("-20");
		choices2.Add ("-3");
		choices2.Add ("9");
		choices2.Add ("-2");
		ans2 = new List<String>();
		ans2.Add ("-20");
		ans2.Add ("-2");
		l2Questions.Add(new Question("Pop two = 21-43", choices2, ans2 , "B"));
		////////////////////////////////////////////////////////////////////
		/// 
		/// 
		//Initialising Level 3
		l3Questions = new List<Question> ();

		choices = new List<String>();
		choices.Add ("6");
		choices.Add ("2");
		choices.Add ("13");
		choices.Add ("11");
		ans = new List<String>();
		ans.Add ("13");
		ans.Add ("2");
		l3Questions.Add(new Question("Pop two = 3 * 5", choices, ans , "B"));

		choices2 = new List<String>();
		choices2.Add ("4");
		choices2.Add ("2");
		choices2.Add ("8");
		choices2.Add ("11");
		ans2 = new List<String>();
		ans2.Add ("2");
		ans2.Add ("8");
		l3Questions.Add(new Question("Pop two = 10 / 1", choices2, ans2 , "B"));

		choices2 = new List<String>();
		choices2.Add ("0");
		choices2.Add ("1");
		choices2.Add ("6");
		choices2.Add ("11");
		ans2 = new List<String>();
		ans2.Add ("0");
		ans2.Add ("1");
		l3Questions.Add(new Question("Pop two = 5/5", choices2, ans2 , "B"));

		choices2 = new List<String>();
		choices2.Add ("72");
		choices2.Add ("-5");
		choices2.Add ("74");
		choices2.Add ("11");
		ans2 = new List<String>();
		ans2.Add ("72");
		l3Questions.Add(new Question("9*8", choices2, ans2 , "A"));

		choices2 = new List<String>();
		choices2.Add ("50");
		choices2.Add ("-3");
		choices2.Add ("9");
		choices2.Add ("-2");
		ans2 = new List<String>();
		ans2.Add ("50");
		l3Questions.Add(new Question("10*5", choices2, ans2 , "A"));

		System.Random rnd = new System.Random ();




		if (level == 1)
		{
			if (resultCount >= 3) {
				level += 1;
				questions = l2Questions.OrderBy(x => rnd.Next(0,9)).Take(5).ToList();	
			} else {
				questions = l1Questions.OrderBy(x => rnd.Next(0,9)).Take(5).ToList();
			}
		}
		else if(level == 2)
		{
			if (resultCount >= 3) {
				level += 1;
				questions = l3Questions.OrderBy(x => rnd.Next(0,9)).Take(5).ToList();
			} else {
				questions = l2Questions.OrderBy(x => rnd.Next(0,9)).Take(5).ToList();
			}
		}
		else{
			questions = l3Questions.OrderBy(x => rnd.Next(0,9)).Take(5).ToList();
		}
			

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
		startButton.onClick.AddListener(startButtonClicked);
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
			loadQuestions ();
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

