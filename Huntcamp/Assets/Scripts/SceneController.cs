using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // Start is called before the first frame update
    public void ChangeScene()
    {
        SceneManager.LoadScene("Gameplay");

    }
    //public void ChangeSceneByName(string sceneName)
    //{
    //    SceneManager.LoadScene(SceneName);
    //}
}
