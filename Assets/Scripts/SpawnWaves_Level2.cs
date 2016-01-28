using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
using System.Collections;

public class SpawnWaves_Level2 : MonoBehaviour{
	GameObject Enemy_Dragon;
	GameObject Enemy_FrozenWolf;
	GameObject Enemy_BugSoldier;
	GameObject Enemy_Goblin1;
	GameObject Enemy_Goblin2;
	GameObject Enemy_Mantis;
	GameObject Enemy_Cookie1;
	GameObject Enemy_Santa;
	float delay0 = 2.0f;
	int amount0 = 4;
	float delay1 = 2.0f;
	int amount1 = 12;
	float delay2 = 1.0f;
	int amount2 = 5;
	float delay3 = 1.0f;
	int amount3 = 12;
	float delay4 = 3.0f;
	int amount4 = 8;
	float delay5 = 2.0f;
	int amount5 = 10;
	float delay6 = 3.0f;
	int amount6 = 5;
	float delay7 = 4.0f;
	int amount7 = 4;
	float delay8 = 4.0f;
	int amount8 = 5;
	float delay9 = 1.0f;
	int amount9 = 10;
	List<Vector3> waypoints = new List<Vector3>();
	int wavesamount = 10;
	int playingwave = 0;
	int patternint = 0;
	void Start(){
		Enemy_Dragon = Resources.Load("Prefabs/Enemies/Enemy_Dragon", typeof(GameObject)) as GameObject;
		Enemy_FrozenWolf = Resources.Load("Prefabs/Enemies/Enemy_FrozenWolf", typeof(GameObject)) as GameObject;
		Enemy_BugSoldier = Resources.Load("Prefabs/Enemies/Enemy_BugSoldier", typeof(GameObject)) as GameObject;
		Enemy_Goblin1 = Resources.Load("Prefabs/Enemies/Enemy_Goblin1", typeof(GameObject)) as GameObject;
		Enemy_Goblin2 = Resources.Load("Prefabs/Enemies/Enemy_Goblin2", typeof(GameObject)) as GameObject;
		Enemy_Mantis = Resources.Load("Prefabs/Enemies/Enemy_Mantis", typeof(GameObject)) as GameObject;
		Enemy_Cookie1 = Resources.Load("Prefabs/Enemies/Enemy_Cookie1", typeof(GameObject)) as GameObject;
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
		case 2:
			wave2();
			break;
		case 3:
			wave3();
			break;
		case 4:
			wave4();
			break;
		case 5:
			wave5();
			break;
		case 6:
			wave6();
			break;
		case 7:
			wave7();
			break;
		case 8:
			wave8();
			break;
		case 9:
			wave9();
			break;
	}
	}
	 void wave0(){
		switch(patternint){
			case 0:
				delay0 = delay0 - (Time.deltaTime % 60);
				if(delay0 <= 0){
					GameObject m = Instantiate(Enemy_Dragon, new Vector3(9.0f,32.0f), Quaternion.identity) as GameObject;
					m.SendMessage ("setWaypoints", waypoints, SendMessageOptions.RequireReceiver );
					delay0 = 2.0f;
					patternint++;
					amount0--;
				}
				break;
			case 1:
				delay0 = delay0 - (Time.deltaTime % 60);
				if(delay0 <= 0){
					GameObject m = Instantiate(Enemy_FrozenWolf, new Vector3(9.0f,32.0f), Quaternion.identity) as GameObject;
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
					GameObject m = Instantiate(Enemy_Dragon, new Vector3(9.0f,32.0f), Quaternion.identity) as GameObject;
					m.SendMessage ("setWaypoints", waypoints, SendMessageOptions.RequireReceiver );
					delay1 = 2.0f;
					patternint++;
					amount1--;
				}
				break;
			case 1:
				delay1 = delay1 - (Time.deltaTime % 60);
				if(delay1 <= 0){
					GameObject m = Instantiate(Enemy_Dragon, new Vector3(9.0f,32.0f), Quaternion.identity) as GameObject;
					m.SendMessage ("setWaypoints", waypoints, SendMessageOptions.RequireReceiver );
					delay1 = 2.0f;
					patternint++;
					amount1--;
				}
				break;
			case 2:
				delay1 = delay1 - (Time.deltaTime % 60);
				if(delay1 <= 0){
					GameObject m = Instantiate(Enemy_FrozenWolf, new Vector3(9.0f,32.0f), Quaternion.identity) as GameObject;
					m.SendMessage ("setWaypoints", waypoints, SendMessageOptions.RequireReceiver );
					delay1 = 2.0f;
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
	 void wave2(){
		switch(patternint){
			case 0:
				delay2 = delay2 - (Time.deltaTime % 60);
				if(delay2 <= 0){
					GameObject m = Instantiate(Enemy_Dragon, new Vector3(9.0f,32.0f), Quaternion.identity) as GameObject;
					m.SendMessage ("setWaypoints", waypoints, SendMessageOptions.RequireReceiver );
					delay2 = 1.0f;
					patternint++;
					amount2--;
				}
				break;
			case 1:
				delay2 = delay2 - (Time.deltaTime % 60);
				if(delay2 <= 0){
					GameObject m = Instantiate(Enemy_Dragon, new Vector3(23.7f,0.0f), Quaternion.identity) as GameObject;
					m.SendMessage ("setWaypoints", waypoints, SendMessageOptions.RequireReceiver );
					delay2 = 1.0f;
					patternint++;
					amount2--;
				}
				break;
			case 2:
				delay2 = delay2 - (Time.deltaTime % 60);
				if(delay2 <= 0){
					GameObject m = Instantiate(Enemy_FrozenWolf, new Vector3(9.0f,32.0f), Quaternion.identity) as GameObject;
					m.SendMessage ("setWaypoints", waypoints, SendMessageOptions.RequireReceiver );
					delay2 = 1.0f;
					patternint++;
					amount2--;
				}
				break;
			case 3:
				delay2 = delay2 - (Time.deltaTime % 60);
				if(delay2 <= 0){
					GameObject m = Instantiate(Enemy_FrozenWolf, new Vector3(9.0f,32.0f), Quaternion.identity) as GameObject;
					m.SendMessage ("setWaypoints", waypoints, SendMessageOptions.RequireReceiver );
					delay2 = 1.0f;
					patternint++;
					amount2--;
				}
				break;
			case 4:
				delay2 = delay2 - (Time.deltaTime % 60);
				if(delay2 <= 0){
					GameObject m = Instantiate(Enemy_BugSoldier, new Vector3(9.0f,32.0f), Quaternion.identity) as GameObject;
					m.SendMessage ("setWaypoints", waypoints, SendMessageOptions.RequireReceiver );
					delay2 = 1.0f;
					patternint = 0;
					amount2--;
				}
				break;
	}
		if(amount2 <= 0){
			playingwave++;
			patternint = 0;
		}
	}
	 void wave3(){
		switch(patternint){
			case 0:
				delay3 = delay3 - (Time.deltaTime % 60);
				if(delay3 <= 0){
					GameObject m = Instantiate(Enemy_FrozenWolf, new Vector3(9.0f,32.0f), Quaternion.identity) as GameObject;
					m.SendMessage ("setWaypoints", waypoints, SendMessageOptions.RequireReceiver );
					delay3 = 1.0f;
					patternint++;
					amount3--;
				}
				break;
			case 1:
				delay3 = delay3 - (Time.deltaTime % 60);
				if(delay3 <= 0){
					GameObject m = Instantiate(Enemy_FrozenWolf, new Vector3(9.0f,32.0f), Quaternion.identity) as GameObject;
					m.SendMessage ("setWaypoints", waypoints, SendMessageOptions.RequireReceiver );
					delay3 = 1.0f;
					patternint++;
					amount3--;
				}
				break;
			case 2:
				delay3 = delay3 - (Time.deltaTime % 60);
				if(delay3 <= 0){
					GameObject m = Instantiate(Enemy_Dragon, new Vector3(9.0f,32.0f), Quaternion.identity) as GameObject;
					m.SendMessage ("setWaypoints", waypoints, SendMessageOptions.RequireReceiver );
					delay3 = 1.0f;
					patternint = 0;
					amount3--;
				}
				break;
	}
		if(amount3 <= 0){
			playingwave++;
			patternint = 0;
		}
	}
	 void wave4(){
		switch(patternint){
			case 0:
				delay4 = delay4 - (Time.deltaTime % 60);
				if(delay4 <= 0){
					GameObject m = Instantiate(Enemy_Goblin1, new Vector3(9.0f,32.0f), Quaternion.identity) as GameObject;
					m.SendMessage ("setWaypoints", waypoints, SendMessageOptions.RequireReceiver );
					delay4 = 3.0f;
					patternint++;
					amount4--;
				}
				break;
			case 1:
				delay4 = delay4 - (Time.deltaTime % 60);
				if(delay4 <= 0){
					GameObject m = Instantiate(Enemy_Goblin2, new Vector3(9.0f,32.0f), Quaternion.identity) as GameObject;
					m.SendMessage ("setWaypoints", waypoints, SendMessageOptions.RequireReceiver );
					delay4 = 3.0f;
					patternint = 0;
					amount4--;
				}
				break;
	}
		if(amount4 <= 0){
			playingwave++;
			patternint = 0;
		}
	}
	 void wave5(){
		switch(patternint){
			case 0:
				delay5 = delay5 - (Time.deltaTime % 60);
				if(delay5 <= 0){
					GameObject m = Instantiate(Enemy_Goblin1, new Vector3(9.0f,32.0f), Quaternion.identity) as GameObject;
					m.SendMessage ("setWaypoints", waypoints, SendMessageOptions.RequireReceiver );
					delay5 = 2.0f;
					patternint++;
					amount5--;
				}
				break;
			case 1:
				delay5 = delay5 - (Time.deltaTime % 60);
				if(delay5 <= 0){
					GameObject m = Instantiate(Enemy_Goblin2, new Vector3(9.0f,32.0f), Quaternion.identity) as GameObject;
					m.SendMessage ("setWaypoints", waypoints, SendMessageOptions.RequireReceiver );
					delay5 = 2.0f;
					patternint = 0;
					amount5--;
				}
				break;
	}
		if(amount5 <= 0){
			playingwave++;
			patternint = 0;
		}
	}
	 void wave6(){
		switch(patternint){
			case 0:
				delay6 = delay6 - (Time.deltaTime % 60);
				if(delay6 <= 0){
					GameObject m = Instantiate(Enemy_Mantis, new Vector3(9.0f,32.0f), Quaternion.identity) as GameObject;
					m.SendMessage ("setWaypoints", waypoints, SendMessageOptions.RequireReceiver );
					delay6 = 3.0f;
					patternint = 0;
					amount6--;
				}
				break;
	}
		if(amount6 <= 0){
			playingwave++;
			patternint = 0;
		}
	}
	 void wave7(){
		switch(patternint){
			case 0:
				delay7 = delay7 - (Time.deltaTime % 60);
				if(delay7 <= 0){
					GameObject m = Instantiate(Enemy_Cookie1, new Vector3(9.0f,32.0f), Quaternion.identity) as GameObject;
					m.SendMessage ("setWaypoints", waypoints, SendMessageOptions.RequireReceiver );
					delay7 = 4.0f;
					patternint = 0;
					amount7--;
				}
				break;
	}
		if(amount7 <= 0){
			playingwave++;
			patternint = 0;
		}
	}
	 void wave8(){
		switch(patternint){
			case 0:
				delay8 = delay8 - (Time.deltaTime % 60);
				if(delay8 <= 0){
					GameObject m = Instantiate(Enemy_Cookie1, new Vector3(9.0f,32.0f), Quaternion.identity) as GameObject;
					m.SendMessage ("setWaypoints", waypoints, SendMessageOptions.RequireReceiver );
					delay8 = 4.0f;
					patternint++;
					amount8--;
				}
				break;
			case 1:
				delay8 = delay8 - (Time.deltaTime % 60);
				if(delay8 <= 0){
					GameObject m = Instantiate(Enemy_Cookie1, new Vector3(9.0f,32.0f), Quaternion.identity) as GameObject;
					m.SendMessage ("setWaypoints", waypoints, SendMessageOptions.RequireReceiver );
					delay8 = 4.0f;
					patternint++;
					amount8--;
				}
				break;
			case 2:
				delay8 = delay8 - (Time.deltaTime % 60);
				if(delay8 <= 0){
					GameObject m = Instantiate(Enemy_Cookie1, new Vector3(9.0f,32.0f), Quaternion.identity) as GameObject;
					m.SendMessage ("setWaypoints", waypoints, SendMessageOptions.RequireReceiver );
					delay8 = 4.0f;
					patternint++;
					amount8--;
				}
				break;
			case 3:
				delay8 = delay8 - (Time.deltaTime % 60);
				if(delay8 <= 0){
					GameObject m = Instantiate(Enemy_Cookie1, new Vector3(9.0f,32.0f), Quaternion.identity) as GameObject;
					m.SendMessage ("setWaypoints", waypoints, SendMessageOptions.RequireReceiver );
					delay8 = 4.0f;
					patternint++;
					amount8--;
				}
				break;
			case 4:
				delay8 = delay8 - (Time.deltaTime % 60);
				if(delay8 <= 0){
					GameObject m = Instantiate(Enemy_Santa, new Vector3(9.0f,32.0f), Quaternion.identity) as GameObject;
					m.SendMessage ("setWaypoints", waypoints, SendMessageOptions.RequireReceiver );
					delay8 = 4.0f;
					patternint = 0;
					amount8--;
				}
				break;
	}
		if(amount8 <= 0){
			playingwave++;
			patternint = 0;
		}
	}
	 void wave9(){
		switch(patternint){
			case 0:
				delay9 = delay9 - (Time.deltaTime % 60);
				if(delay9 <= 0){
					GameObject m = Instantiate(Enemy_Santa, new Vector3(9.0f,32.0f), Quaternion.identity) as GameObject;
					m.SendMessage ("setWaypoints", waypoints, SendMessageOptions.RequireReceiver );
					delay9 = 1.0f;
					patternint = 0;
					amount9--;
				}
				break;
	}
		if(amount9 <= 0){
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
