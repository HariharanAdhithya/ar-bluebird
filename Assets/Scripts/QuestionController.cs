using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class QuestionController : MonoBehaviour {

	public static QuestionController main;
	public List<String> states;
	public Question Question;
	public GameObject balloon;
	public Transform imageTarget;
	public List<GameObject> balloonList;
	public List<Color> colorList;

	public static float timer;

	void Awake () {
		Question = GameController.getQuestion ();
		main = this;
		timer = 10;
		GameObject.Find ("Timer").GetComponent<Text> ().text = timer.ToString("F");
		SpawnBalloons ();
	}

	public void SpawnBalloons(){
		GameObject obText = GameObject.Find ("Text");
		obText.GetComponent<Text>().text = Question.ques;
		obText.GetComponent<Text>().transform.LookAt(Camera.main.transform);

		float dist = -1.4f;
		for(int i = 0; i < Question.choices.Count; i++){
			GameObject obj = Instantiate(balloon);
			obj.GetComponentInChildren<TextMesh>().text = Question.choices[i].ToString();
			obj.GetComponentInChildren<TextMesh>().transform.LookAt(Camera.main.transform);
			obj.GetComponentInChildren<TextMesh>().transform.eulerAngles = new Vector3  ( 0, 180 , 0 );
			Vector3 objPos = new Vector3(dist,0.6f,1f);
			dist += 2.5f;
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

		if (timer > 0.0f) {
			timer -= Time.deltaTime;
			GameObject.Find ("Timer").GetComponent<Text> ().text = timer.ToString("F");
		} else {
				GameController.addQuestionResult (Question, "2");
		}

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
