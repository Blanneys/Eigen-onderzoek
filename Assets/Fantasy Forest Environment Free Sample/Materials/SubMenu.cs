using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubMenu : MonoBehaviour
{
    [Header("Buttons")]
    public GameObject _firstchoice;
    public GameObject _secondchoice;
    public GameObject _thirdchoice;
    public GameObject _fourthchoice;
    public GameObject _fifthchoice;
    public GameObject _sixthchoice;
    public GameObject _seventhchoice;
    public GameObject[] choices;

    public List<GameObject> selectedChoices = new List<GameObject>();

    private void Start()
    {
        choices = new GameObject[8];
        choices[0] = _firstchoice;
        choices[1] = _secondchoice;
        choices[2] = _thirdchoice;
        choices[3] = _fourthchoice;
        choices[4] = _fifthchoice;
        choices[5] = _sixthchoice;
        choices[6] = _seventhchoice;
    }

    public int stage = 0;
    public Color[] kleur;

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (stage > 0 && stage < kleur.Length)
        {

        }
    }
}
