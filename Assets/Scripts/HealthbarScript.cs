using UnityEngine;
using System.Collections;
using UnityEngine.UI;
/*
Dieses script hält die lebensanzeige  und aktualisiert den lebensbalken der gui
die setter funktion wird von dem script aufgerufen, dass die player attribute hält
*/
public class HealthbarScript : MonoBehaviour {

	public float health;
	public float length;
	private double healthPercentage;
	private float actualWidth;
	float maxHealth;


	public GameObject healthbarImage;
	private GameObject transformedHealthbar;
	private RectTransform rt;
	
	
	// Use this for initialization
	void Start () {
		Debug.Log ("start");
		//health = 100.0f;
		length = 500.0f;
		healthPercentage = 100.00;
		
		rt = (RectTransform)healthbarImage.transform;
		
		actualWidth = rt.rect.width;
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void initializeMaxHealth(float health){
		Debug.Log ("init");
		maxHealth = health;
		this.health = maxHealth;
		setHealth (maxHealth);

	}

	public void setHealth(float health){
		
		rt.sizeDelta = new Vector2( health * (length/maxHealth), 40f);
	}
}
