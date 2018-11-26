using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
using UnityEngine.SceneManagement;

public class QuestionController : MonoBehaviour {

	public static QuestionController main;
	public List<String> states;
	public Question Question;
	public GameObject balloon;
	public Transform imageTarget;
	public List<GameObject> balloonList;
	public List<Color> colorList;

	void Awake () {
		Question = GameController.getQuestion ();
		main = this;
		SpawnBalloons ();
	}

	public void SpawnBalloons(){
		for(int i = 0; i < Question.choices.Count; i++){
			GameObject obj = Instantiate(balloon);
			obj.GetComponentInChildren<TextMesh>().text = Question.choices[i].ToString();
			obj.GetComponentInChildren<TextMesh>().transform.LookAt(Camera.main.transform);
			Vector3 objPos = new Vector3(UnityEngine.Random.Range(-1.4f, 1.4f),UnityEngine.Random.Range(-0.5f, 0.6f),UnityEngine.Random.Range(-0.9f, 1f));
			obj.transform.parent = imageTarget;
			obj.transform.localScale = balloon.transform.localScale;
			balloon.transform.localPosition = objPos;
			balloonList.Add(obj);
		}
		balloonList.Add(balloon);	

	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public QuestionController()
	{
	}

	public QuestionController (List<string> states)
	{
		this.states = states;
	}

	public void addState(String newBalloon)
	{
		this.states.Add (newBalloon);
		Validate ();
	}

	public int Validate()
	{
		int result;

		if (Question.type == "B" && states.Count < 2) {
			result =  0;
		} 
		else {
			if (Question.type == "A") {
				result =  (states [0] == Question.ans [0] ? 1 : 2);
			} 
			else {

				result =  ((states.All (Question.ans.Contains) && states.Count == Question.ans.Count) ? 1 : 2);
			}
		}

		if (result == 1 || result == 2) {
			GameController.addQuestionResult (Question, "" + result);
		}

		return result;
	}


}
