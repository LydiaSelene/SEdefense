using UnityEngine;
using UnityEditor;
using System.Collections;

public class Level1 : MonoBehaviour{
	GameObject En_Dragon;
	GameObject En_FrozenWolf;
	GameObject En_Goblin1;
	GameObject En_Cookie1;
	GameObject En_Mantis;
	GameObject En_Santa;
	float delay0 = 2.0f;
	int amount0 = 15;
	float delay1 = 3.0f;
	int amount1 = 10;
	int wavesamount = 2;
	int playingwave = 0;
	int patternint = 0;
	void Start(){
		En_Dragon = AssetDatabase.LoadAssetAtPath("Assets/Prefabs/Enemies/En_Dragon.prefab", typeof(GameObject)) as GameObject;
		En_FrozenWolf = AssetDatabase.LoadAssetAtPath("Assets/Prefabs/Enemies/En_FrozenWolf.prefab", typeof(GameObject)) as GameObject;
		En_Goblin1 = AssetDatabase.LoadAssetAtPath("Assets/Prefabs/Enemies/En_Goblin1.prefab", typeof(GameObject)) as GameObject;
		En_Cookie1 = AssetDatabase.LoadAssetAtPath("Assets/Prefabs/Enemies/En_Cookie1.prefab", typeof(GameObject)) as GameObject;
		En_Mantis = AssetDatabase.LoadAssetAtPath("Assets/Prefabs/Enemies/En_Mantis.prefab", typeof(GameObject)) as GameObject;
		En_Santa = AssetDatabase.LoadAssetAtPath("Assets/Prefabs/Enemies/En_Santa.prefab", typeof(GameObject)) as GameObject;
	}
	void Update(){
	switch(playingwave){
		case 0:
			wave0();
			break;
		case 1:
			wave1();
			break;
	}
	}
	 void wave0(){
		switch(patternint){
			case 0:
				delay0 = delay0 - (Time.deltaTime % 60);
				if(delay0 <= 0){
					GameObject m = Instantiate(En_Dragon, new Vector3(15.0f,3.0f), Quaternion.identity) as GameObject;
					delay0 = 2.0f;
					patternint++;
					amount0--;
				}
				break;
			case 1:
				delay0 = delay0 - (Time.deltaTime % 60);
				if(delay0 <= 0){
					GameObject m = Instantiate(En_Dragon, new Vector3(15.0f,4.0f), Quaternion.identity) as GameObject;
					delay0 = 2.0f;
					patternint++;
					amount0--;
				}
				break;
			case 2:
				delay0 = delay0 - (Time.deltaTime % 60);
				if(delay0 <= 0){
					GameObject m = Instantiate(En_FrozenWolf, new Vector3(14.0f,3.0f), Quaternion.identity) as GameObject;
					delay0 = 2.0f;
					patternint++;
					amount0--;
				}
				break;
			case 3:
				delay0 = delay0 - (Time.deltaTime % 60);
				if(delay0 <= 0){
					GameObject m = Instantiate(En_FrozenWolf, new Vector3(14.0f,4.0f), Quaternion.identity) as GameObject;
					delay0 = 2.0f;
					patternint++;
					amount0--;
				}
				break;
			case 4:
				delay0 = delay0 - (Time.deltaTime % 60);
				if(delay0 <= 0){
					GameObject m = Instantiate(En_Goblin1, new Vector3(13.0f,5.0f), Quaternion.identity) as GameObject;
					delay0 = 2.0f;
					patternint = 0;
					amount0--;
				}
				break;
	}
		if(amount0 <= 0){
			playingwave++;
            patternint = 0;		
        }
	}
	 void wave1(){
		switch(patternint){
			case 0:
				delay1 = delay1 - (Time.deltaTime % 60);
				if(delay1 <= 0){
					GameObject m = Instantiate(En_Mantis, new Vector3(10.0f,5.0f), Quaternion.identity) as GameObject;
					delay1 = 3.0f;
					patternint++;
					amount1--;
				}
				break;
			case 1:
				delay1 = delay1 - (Time.deltaTime % 60);
				if(delay1 <= 0){
					GameObject m = Instantiate(En_Cookie1, new Vector3(11.0f,5.0f), Quaternion.identity) as GameObject;
					delay1 = 3.0f;
					patternint++;
					amount1--;
				}
				break;
			case 2:
				delay1 = delay1 - (Time.deltaTime % 60);
				if(delay1 <= 0){
					GameObject m = Instantiate(En_Santa, new Vector3(9.0f,5.0f), Quaternion.identity) as GameObject;
					delay1 = 3.0f;
					patternint = 0;
					amount1--;
				}
				break;
	}
		if(amount1 <= 0){
			playingwave++;
            patternint = 0;
        }
	}
	public int getWavesAmount(){
		return wavesamount;
	}
	public int getCurWave(){
		return playingwave+1;
	}
}
