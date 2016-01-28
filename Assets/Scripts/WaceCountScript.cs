using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WaceCountScript : MonoBehaviour {

/*
	dieses script erstellt und aktualisiert die anzeige der waves in der GUI auf der schriftrolle
	entsprechend dieses scripts werden die maximale anzahl und die aktuelle zahl der wave aktualisiert
	die informationen der waves erlangt dieses script durch das generiert level-script
*/
	SpawnWaves_Level1 waveScript;
	public GameObject currentWaveText;
	public GameObject levelObject;
	private int currentWave;
	private int maxWave;
	private int checkWave;
	Text currentWaveString;
	private GameObject win;
	private bool winBool;
	
	//initialisiere die komponenten der wave-anzeige
	//dabei werden instanzen der objete erstellt, die auf das level-script verweisen
	//dies geschiet durch den zugriff auf die getter der generierten level-klasse
	void Start () {
		GameObject go = GameObject.FindWithTag("SpawnScript");
		waveScript = (SpawnWaves_Level1)go.GetComponent (typeof(SpawnWaves_Level1));
		currentWave = waveScript.getCurWave();
		maxWave = waveScript.getWavesAmount();
		currentWaveString = currentWaveText.GetComponent<Text>();
		currentWaveString.text = "" + currentWave + "/" + maxWave;
		winBool = false;
	}
	
	// es wird geprüft, ob die momentane anzeige mit der anzahl der 
	// aktuellen wave übereinstimmt 
	void Update () {
		checkWave = waveScript.getCurWave();
		if (!(checkWave > maxWave)) {
			if (currentWave != checkWave) {
				currentWave = checkWave;
				currentWaveString.text = "" + currentWave + "/" + maxWave;
			}
		} else {
			if (!winBool && (GameObject.FindWithTag ("FlyingEnemy") == null) && (GameObject.FindWithTag ("GroundEnemy") == null)) {
				Debug.Log ("you won");
				win =  Resources.Load ("Prefabs/Win", typeof(GameObject)) as GameObject;
				Instantiate (win, Camera.main.ScreenToViewportPoint(new Vector3(0,0,0)), Quaternion.identity);
				Time.timeScale = 0.0f;
				winBool = true;
			}
		}
	
	}
	
}
