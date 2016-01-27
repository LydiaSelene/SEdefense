using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MenuLoading : MonoBehaviour {

    public void LoadScene(int scene)
    {
        int loading = scene;
        if (scene == 4)
        {
            loading = Random.Range(1, 4);
        }
        SceneManager.LoadScene(loading);
    }
}
