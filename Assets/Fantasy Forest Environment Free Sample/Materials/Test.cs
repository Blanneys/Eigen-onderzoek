using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject _mainmenu;
    public GameObject _angrymenu;
    public GameObject _badmenu;
    public GameObject _disgustedmenu;
    public GameObject _fearfulmenu;
    public GameObject _happymenu;
    public GameObject _sadmenu;
    public GameObject _surprisedmenu;

    void Start()
    {
        StartCoroutine(BeginTest());
    }

    IEnumerator BeginTest()
    {
        yield return new WaitForSeconds(30);
        _mainmenu.SetActive(true);
        _angryButton();
        
    }

    public void _angryButton()
    {
        _mainmenu.SetActive(false);
        _angrymenu.SetActive(true);

    }
}
