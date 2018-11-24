using System;

namespace AssemblyCSharp
{
	public class QuestionA
	{
		public  String ques;
		public List<String> choices;
		public String ans;

		public QuestionA ()
		{
		}

		public QuestionA (string q, List<String> c, String a)
		{
			ques = q;
			choices = c;
			ans = a;
		
		}

		public string Ques {
			get {
				return this.ques;
			}
		}

		public List Choices {
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

