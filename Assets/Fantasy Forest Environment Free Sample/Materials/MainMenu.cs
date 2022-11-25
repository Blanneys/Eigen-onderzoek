using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject _mainmenu;
    public GameObject _angrymenu;
    public GameObject _badmenu;
    public GameObject _disgustedmenu;
    public GameObject _fearfulmenu;
    public GameObject _happymenu;
    public GameObject _sadmenu;
    public GameObject _surprisedmenu;

    public GameObject _player;

    public Color[] kleur; 
    public int kleurCount;

    void Start()
    {
        if (gameObject.activeSelf == true)
        {
            StartCoroutine(BeginTest());
        }
    }

    IEnumerator BeginTest()
    {
        Debug.Log("Starttest");
        yield return new WaitForSeconds(3);
        _mainmenu.SetActive(true);
        MainMenuButton1();
    }

    public void MainMenuButton1()
    {
        Debug.Log("Start");
        _mainmenu.SetActive(true);
        _angrymenu.SetActive(false);
        _badmenu.SetActive(false);
        _disgustedmenu.SetActive(false);
        _fearfulmenu.SetActive(false);
        _happymenu.SetActive(false);
        _sadmenu.SetActive(false);
        _surprisedmenu.SetActive(false);
    }

    public void AngryMenuButton()
    {
        Debug.Log("Angry");
        _mainmenu.SetActive(false);
        _angrymenu.SetActive(true);
        _badmenu.SetActive(false);
        _disgustedmenu.SetActive(false);
        _fearfulmenu.SetActive(false);
        _happymenu.SetActive(false);
        _sadmenu.SetActive(false);
        _surprisedmenu.SetActive(false);
    }
}
