﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : SingletonMonoBehaviour<Player> {
Player player;
	// Use this for initialization
	void Start () {
		player = GetComponent<Player> ();
	}

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.A))
        {
player.GoRight();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
player.GoLeft();
        }
    }
}
