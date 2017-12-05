using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMentalHealthManager : MonoBehaviour {

	public int playerMaxMHealth;
	public int playerCurrentMHealth;

	// Use this for initialization
	void Start () {
		playerCurrentMHealth = playerMaxMHealth;
	}

	// Update is called once per frame
	void Update () {
		if (playerCurrentMHealth <= 0) {
			gameObject.SetActive (false);
		}
	}
	public void MHurtPlayer(int damageToGive)
	{
		playerCurrentMHealth -= damageToGive;
	}

	public void SetMaxMHealth()
	{
		playerCurrentMHealth = playerMaxMHealth;
	}
}