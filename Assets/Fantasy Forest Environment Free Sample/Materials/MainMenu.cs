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

    void Start()
    {
        if (_player.activeSelf == true)
        {
            StartCoroutine(BeginTest());
        }
    }

    IEnumerator BeginTest()
    {
        yield return new WaitForSeconds(3);
        gameObject.SetActive(true);
    }
}