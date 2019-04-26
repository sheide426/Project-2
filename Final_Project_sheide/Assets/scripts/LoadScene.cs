﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public Object theScene;

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(theScene.name, LoadSceneMode.Single);
    }
}

