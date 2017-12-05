using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

	public Slider PhealthBar;
	public Text PhealthText;
	public PlayerPhysicalHealthManager playerPHealth;

	public Slider MhealthBar;
	public Text MhealthText;
	public PlayerMentalHealthManager playerMHealth;

	private PlayerStats thePS;
	public Text levelText;

	private static bool UIExists;

	// Use this for initialization
	void Start () {
		if (!UIExists) {
			UIExists = true;
			DontDestroyOnLoad (transform.gameObject);
		} else {
			Destroy (gameObject);
		}

		thePS = GetComponent<PlayerStats> ();
	}
	
	// Update is called once per frame
	void Update () {
		PhealthBar.maxValue = playerPHealth.playerMaxPHealth;
		PhealthBar.value = playerPHealth.playerCurrentPHealth;
		PhealthText.text = "Physical Health: " + playerPHealth.playerCurrentPHealth + "/" + playerPHealth.playerMaxPHealth;

		MhealthBar.maxValue = playerMHealth.playerMaxMHealth;
		MhealthBar.value = playerMHealth.playerCurrentMHealth;
		MhealthText.text = "Mental Health: " + playerMHealth.playerCurrentMHealth + "/" + playerMHealth.playerMaxMHealth;

		levelText.text = "PGH: " + thePS.currentLevel;
	}
}
