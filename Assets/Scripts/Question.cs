using System;
using System.Collections.Generic;
using System.Collections;



public class Question
{
	public  String ques;
	public List<String> choices;
	public String ans;
	public String type;


	public Question ()
	{
	}

	public Question (string ques, List<string> choices, string ans, string type)
	{
		this.ques = ques;
		this.choices = choices;
		this.ans = ans;
		this.type = type;
	}
	

	public string Ques {
		get {
			return this.ques;
		}
	}

	public List<String> Choices {
		get {
			return this.choices;
		}
	}

	public string Ans {
		get {
			return this.ans;
		}
	}
}
	