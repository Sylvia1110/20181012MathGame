using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextQuestion : MonoBehaviour {

	public GameObject optionnext;
	public GameObject core;
	public GameObject option1;
	public GameObject option2;
	public GameObject option3;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown()
	{
		core.GetComponent<GameController>().GenerateQuestion();
		option1.GetComponent<TextMesh>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
		option2.GetComponent<TextMesh>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
		option3.GetComponent<TextMesh>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);	

	}

	
}
