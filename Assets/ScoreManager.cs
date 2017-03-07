﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	private Text text;
	private int _score = 0;

	// Use this for initialization
	void Start () {

		text = this.GetComponent<Text> ();
		
	}

	public void AddScore(int scoreToAdd)
	{
		_score += scoreToAdd;
		text.text = "Score : " + _score;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
