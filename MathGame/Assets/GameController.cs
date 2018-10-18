using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public int answer;
	public string ramdomOperator;
	
	public GameObject question;
	public GameObject option1;
	public GameObject option2;
	public GameObject option3;
	public GameObject optionnext;

	int option;

	// Use this for initialization
	void Start () {
		GenerateQuestion();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void GenerateQuestion()
	{
		int a = Random.Range(0, 101);
		int b = Random.Range(0, 101);

		int operatorNumber = Random.Range(0, 3);

		if (operatorNumber == 0)
		{
			ramdomOperator = "+";
			answer = a+b;

	   // 分流一：operatorNumber 為 0，進行加法
		} 
		else if (operatorNumber == 1)
		{
			ramdomOperator = "-";
			answer = a-b;
		}
		else
		{
			ramdomOperator = "*";
			answer = a*b;
		}
			


		option = Random.Range(0, 3);
		
		int rand = Random.Range(0, 3);

		if (option == 0)
		{
    		option1.GetComponent<TextMesh>().text = answer.ToString();
    		option2.GetComponent<TextMesh>().text = (answer + (rand * 2 - 1)).ToString();
    		option3.GetComponent<TextMesh>().text = (answer + (rand * 2 + 2)).ToString();
    		option1.GetComponent<Option>().isCorrect = true;
    		option2.GetComponent<Option>().isCorrect = false;
    		option3.GetComponent<Option>().isCorrect = false;
    		
		}
		else if (option == 1)
		{
    		option1.GetComponent<TextMesh>().text = (answer + (rand * 2 - 1)).ToString();
    		option2.GetComponent<TextMesh>().text = answer.ToString();
    		option3.GetComponent<TextMesh>().text = (answer + (rand * 2 + 2)).ToString();
    		option1.GetComponent<Option>().isCorrect = false;
    		option2.GetComponent<Option>().isCorrect = true;
    		option3.GetComponent<Option>().isCorrect = false;
		}
		else
		{
			option1.GetComponent<TextMesh>().text = (answer + (rand * 2 - 1)).ToString();
    		option2.GetComponent<TextMesh>().text = (answer + (rand * 2 + 2)).ToString();
    		option3.GetComponent<TextMesh>().text = answer.ToString();
    		option1.GetComponent<Option>().isCorrect = false;
    		option2.GetComponent<Option>().isCorrect = false;
    		option3.GetComponent<Option>().isCorrect = true;
		}

		question.GetComponent<TextMesh>().text = a + " " + ramdomOperator + " " + b + " = ?";


	}

	public void displayCorrect() {

		if(option == 0) 
		{
			option1.GetComponent<TextMesh>().color = new Color(1.0f, 0.5f, 0.0f, 1.0f);
		}
		else if(option == 1) 
		{
			option2.GetComponent<TextMesh>().color = new Color(1.0f, 0.5f, 0.0f, 1.0f);
		}
		else {

			option3.GetComponent<TextMesh>().color = new Color(1.0f, 0.5f, 0.0f, 1.0f);
		}
	}
}
