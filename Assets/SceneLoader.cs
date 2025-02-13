using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private int _sceneToLoad = -1;

    public void LoadScene()
    {
        if (_sceneToLoad == -1)
            return;

        SceneManager.LoadScene(_sceneToLoad);
    }
}
