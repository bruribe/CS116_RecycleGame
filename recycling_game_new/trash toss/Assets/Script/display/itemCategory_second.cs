﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class itemCategory_second : MonoBehaviour {

	Text text;

	// Use this for initialization
	void Start()
	{
		text = GetComponent<Text>();
		switch (tips.tipsSlot2){
		case 1:
			text.text = "--compost";
			break;
		case 2:
			text.text = "--other";
			break;
		}
	}

	// Update is called once per frame
	void Update()
	{
	}
}
