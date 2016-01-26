using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MenuLoading : MonoBehaviour {

    public void LoadScene(int scene)
    {
        Application.LoadLevel(scene);
    }
}
