using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPhysicalHealthManager : MonoBehaviour {

	public int playerMaxPHealth;
	public int playerCurrentPHealth;

	// Use this for initialization
	void Start () {
		playerCurrentPHealth = playerMaxPHealth;
	}
	
	// Update is called once per frame
	void Update () {
		if (playerCurrentPHealth <= 0) {
			gameObject.SetActive (false);
		}
	}
	public void PHurtPlayer(int damageToGive)
		{
		playerCurrentPHealth -= damageToGive;
		}

	public void SetMaxPHealth()
		{
		playerCurrentPHealth = playerMaxPHealth;
		}
}