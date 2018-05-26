﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuControl : MonoBehaviour
{

    public Camera MainMenuCamera;
    public Image LevelIamge;
    public GameObject LevelPanel;
    public Image MenuIamge;
    public GameObject MenuPanel;
    public GameObject tujian;

    public void Start()
    {
        FadeInOut.instance.transition();
        LevelPanel.SetActive(false);
        MenuPanel.SetActive(true);
        tujian.SetActive(false);
        LevelIamge.gameObject.SetActive(false);
        MenuIamge.gameObject.SetActive(true);
    }

    public void firstLevel()
    {
        FadeInOut.instance.transition();
        SceneManager.LoadScene("BattleScene");
    }

    public void secondLevel()
    {
        FadeInOut.instance.transition();
        SceneManager.LoadScene("BattleScene");
    }

    public void back()
    {
        FadeInOut.instance.transition();
        MenuPanel.SetActive(true);
        LevelPanel.SetActive(false);
        LevelIamge.gameObject.SetActive(false);
        MenuIamge.gameObject.SetActive(true);
    }

    public void openTujian()
    {
        tujian.SetActive(true);
        LevelPanel.SetActive(false);
        MenuPanel.SetActive(true);
        FadeInOut.instance.transition();
    }

    public void openLevel()
    {
        MenuPanel.SetActive(false);
        MenuIamge.gameObject.SetActive(false);
        LevelPanel.SetActive(true);
        LevelIamge.gameObject.SetActive(true);
        FadeInOut.instance.transition();
    }
    public void Exit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
    Application.Quit();
#endif
    }
}