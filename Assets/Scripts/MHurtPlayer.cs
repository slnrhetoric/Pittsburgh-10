﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MHurtPlayer : MonoBehaviour {

	public int damageToGive;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.name == "player") 
		{
			other.gameObject.GetComponent<PlayerMentalHealthManager> ().MHurtPlayer (damageToGive);
		}
	}
}
