﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnSystem : MonoBehaviour {

    public spawnTrash spawnFunc;

    private float time = 0;
	
	// Update is called once per frame
	void Update ()
    {
        time += Time.deltaTime;

        if(time > difficultySettings.spawnGap)
        {
            spawnFunc.spawn();
            time = 0;
        }
	}
}
