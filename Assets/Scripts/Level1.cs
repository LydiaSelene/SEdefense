using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
using System.Collections;

public class Level1 : MonoBehaviour{
	GameObject Enemy_Dragon;
	GameObject Enemy_FrozenWolf;
	GameObject Enemy_Goblin1;
	GameObject Enemy_Cookie1;
	GameObject Enemy_Mantis;
	GameObject Enemy_Santa;
	float delay0 = 2.0f;
	int amount0 = 15;
	float delay1 = 3.0f;
	int amount1 = 10;
	List<Vector3> waypoints = new List<Vector3>();	int wavesamount = 2;
	int playingwave = 0;
	int patternint = 0;
	void Start(){
		Enemy_Dragon = Resources.Load("Prefabs/Enemies/Enemy_Dragon", typeof(GameObject)) as GameObject;
		Enemy_FrozenWolf = Resources.Load("Prefabs/Enemies/Enemy_FrozenWolf", typeof(GameObject)) as GameObject;
		Enemy_Goblin1 = Resources.Load("Prefabs/Enemies/Enemy_Goblin1", typeof(GameObject)) as GameObject;
		Enemy_Cookie1 = Resources.Load("Prefabs/Enemies/Enemy_Cookie1", typeof(GameObject)) as GameObject;
		Enemy_Mantis = Resources.Load("Prefabs/Enemies/Enemy_Mantis", typeof(GameObject)) as GameObject;
		Enemy_Santa = Resources.Load("Prefabs/Enemies/Enemy_Santa", typeof(GameObject)) as GameObject;
		Transform wayPointsChild = transform.GetChild (0);
		for (int i = 0; i < wayPointsChild.childCount; i++){
			waypoints.Add(wayPointsChild.GetChild(i).transform.position);
		}
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
					GameObject m = Instantiate(Enemy_Dragon, new Vector3(15.0f,3.0f), Quaternion.identity) as GameObject;
					m.SendMessage ("setWaypoints", waypoints, SendMessageOptions.RequireReceiver );
					delay0 = 2.0f;
					patternint++;
					amount0--;
				}
				break;
			case 1:
				delay0 = delay0 - (Time.deltaTime % 60);
				if(delay0 <= 0){
					GameObject m = Instantiate(Enemy_Dragon, new Vector3(15.0f,4.0f), Quaternion.identity) as GameObject;
					m.SendMessage ("setWaypoints", waypoints, SendMessageOptions.RequireReceiver );
					delay0 = 2.0f;
					patternint++;
					amount0--;
				}
				break;
			case 2:
				delay0 = delay0 - (Time.deltaTime % 60);
				if(delay0 <= 0){
					GameObject m = Instantiate(Enemy_FrozenWolf, new Vector3(14.0f,3.0f), Quaternion.identity) as GameObject;
					m.SendMessage ("setWaypoints", waypoints, SendMessageOptions.RequireReceiver );
					delay0 = 2.0f;
					patternint++;
					amount0--;
				}
				break;
			case 3:
				delay0 = delay0 - (Time.deltaTime % 60);
				if(delay0 <= 0){
					GameObject m = Instantiate(Enemy_FrozenWolf, new Vector3(14.0f,4.0f), Quaternion.identity) as GameObject;
					m.SendMessage ("setWaypoints", waypoints, SendMessageOptions.RequireReceiver );
					delay0 = 2.0f;
					patternint++;
					amount0--;
				}
				break;
			case 4:
				delay0 = delay0 - (Time.deltaTime % 60);
				if(delay0 <= 0){
					GameObject m = Instantiate(Enemy_Goblin1, new Vector3(13.0f,5.0f), Quaternion.identity) as GameObject;
					m.SendMessage ("setWaypoints", waypoints, SendMessageOptions.RequireReceiver );
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
					GameObject m = Instantiate(Enemy_Mantis, new Vector3(10.0f,5.0f), Quaternion.identity) as GameObject;
					m.SendMessage ("setWaypoints", waypoints, SendMessageOptions.RequireReceiver );
					delay1 = 3.0f;
					patternint++;
					amount1--;
				}
				break;
			case 1:
				delay1 = delay1 - (Time.deltaTime % 60);
				if(delay1 <= 0){
					GameObject m = Instantiate(Enemy_Cookie1, new Vector3(11.0f,5.0f), Quaternion.identity) as GameObject;
					m.SendMessage ("setWaypoints", waypoints, SendMessageOptions.RequireReceiver );
					delay1 = 3.0f;
					patternint++;
					amount1--;
				}
				break;
			case 2:
				delay1 = delay1 - (Time.deltaTime % 60);
				if(delay1 <= 0){
					GameObject m = Instantiate(Enemy_Santa, new Vector3(9.0f,5.0f), Quaternion.identity) as GameObject;
					m.SendMessage ("setWaypoints", waypoints, SendMessageOptions.RequireReceiver );
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
