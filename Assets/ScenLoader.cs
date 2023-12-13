using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenLoader : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }
}
