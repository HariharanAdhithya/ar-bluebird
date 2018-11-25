using System;
using System.Collections.Generic;
using System.Collections;



public class Question
{
	public  String ques;
	public List<String> choices;
	public List<String> ans;
	public String type;


	public Question ()
	{
	}

	public Question (String ques, List<String> choices, List<String> ans, String type)
	{
		this.ques = ques;
		this.choices = choices;
		this.ans = ans;
		this.type = type;
	}
	

	public String Ques {
		get {
			return this.ques;
		}
	}

	public List<String> Choices {
		get {
			return this.choices;
		}
	}

	public List<String> Ans {
		get {
			return this.ans;
		}
	}
}
	