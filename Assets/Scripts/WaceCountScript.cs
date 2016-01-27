using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WaceCountScript : MonoBehaviour {

/*
	dieses script erstellt und aktualisiert die anzeige der waves in der GUI auf der schriftrolle
	entsprechend dieses scripts werden die maximale anzahl und die aktuelle zahl der wave aktualisiert
	die informationen der waves erlangt dieses script durch das generiert level-script
*/
	Level1 waveScript;
	public GameObject currentWaveText;
	public GameObject levelObject;
	private int currentWave;
	private int maxWave;
	private int checkWave;
	Text currentWaveString;
	
	//initialisiere die komponenten der wave-anzeige
	//dabei werden instanzen der objete erstellt, die auf das level-script verweisen
	//dies geschiet durch den zugriff auf die getter der generierten level-klasse
	void Start () {
		waveScript = levelObject.GetComponent<Level1> ();
		currentWave = waveScript.getCurWave();
		maxWave = waveScript.getWavesAmount();
		currentWaveString = currentWaveText.GetComponent<Text>();
		currentWaveString.text = "" + currentWave + "/" + maxWave;
	}
	
	// es wird geprüft, ob die momentane anzeige mit der anzahl der 
	// aktuellen wave übereinstimmt 
	void Update () {
		checkWave = waveScript.getCurWave();
		if(currentWave != checkWave){
			currentWave = checkWave;
			currentWaveString.text = "" + currentWave + "/" + maxWave;
		}
	
	}
	
}
