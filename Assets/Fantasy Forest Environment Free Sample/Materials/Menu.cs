using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Menu : MonoBehaviour
{
    public GameObject _mainmenu;
    public GameObject _angrymenu;
    public GameObject _badmenu;
    public GameObject _disgustedmenu;
    public GameObject _fearfulmenu;
    public GameObject _happymenu;
    public GameObject _sadmenu;
    public GameObject _surprisedmenu;

    public GameObject _menu2;

    void Start()
    {
        if (gameObject.activeSelf == true)
        {
            StartCoroutine(Menustart());
        }
    }
    IEnumerator Menustart()
    {
        yield return new WaitForSeconds(3);
        MainMenuButton();
    }

    public void MainMenuButton()
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
