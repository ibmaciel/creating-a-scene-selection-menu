﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadOnClick : MonoBehaviour
{
    public GameObject loadingImage;

    public void LoadScene(int level)
    {
        loadingImage.SetActive(true);
        SceneManager.LoadScene(level);        
    }
}