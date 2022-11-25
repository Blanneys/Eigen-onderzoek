using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject MainMenus;
    public GameObject AngryMenu;
    public GameObject BadMenu;
    public GameObject DisgustedMenu;
    public GameObject FearfulMenu;
    public GameObject HappyMenu;
    public GameObject SadMenu;
    public GameObject SurprisedMenu;

    // Start is called before the first frame update
    void Start()
    {
        MainMenusButton();
    }

    public void MainMenusButton()
    {
        MainMenus.SetActive(true);
        AngryMenu.SetActive(false);
        BadMenu.SetActive(false);
        DisgustedMenu.SetActive(false);
        FearfulMenu.SetActive(false);
        HappyMenu.SetActive(false);
        SadMenu.SetActive(false);
        SurprisedMenu.SetActive(false);
    }

    public void AngryMenuButton()
    {
        MainMenus.SetActive(false);
        AngryMenu.SetActive(true);
        BadMenu.SetActive(false);
        DisgustedMenu.SetActive(false);
        FearfulMenu.SetActive(false);
        HappyMenu.SetActive(false);
        SadMenu.SetActive(false);
        SurprisedMenu.SetActive(false);
    }

    public void BadMenuButton()
    {
        MainMenus.SetActive(false);
        AngryMenu.SetActive(false);
        BadMenu.SetActive(true);
        DisgustedMenu.SetActive(false);
        FearfulMenu.SetActive(false);
        HappyMenu.SetActive(false);
        SadMenu.SetActive(false);
        SurprisedMenu.SetActive(false);
    }

    public void DisgustedMenuButton()
    {
        MainMenus.SetActive(false);
        AngryMenu.SetActive(false);
        BadMenu.SetActive(false);
        DisgustedMenu.SetActive(true);
        FearfulMenu.SetActive(false);
        HappyMenu.SetActive(false);
        SadMenu.SetActive(false);
        SurprisedMenu.SetActive(false);
    }

    public void FearfulMenuButton()
    {
        MainMenus.SetActive(false);
        AngryMenu.SetActive(false);
        BadMenu.SetActive(false);
        DisgustedMenu.SetActive(false);
        FearfulMenu.SetActive(true);
        HappyMenu.SetActive(false);
        SadMenu.SetActive(false);
        SurprisedMenu.SetActive(false);
    }

    public void HappyMenuButton()
    {
        MainMenus.SetActive(false);
        AngryMenu.SetActive(false);
        BadMenu.SetActive(false);
        DisgustedMenu.SetActive(false);
        FearfulMenu.SetActive(false);
        HappyMenu.SetActive(true);
        SadMenu.SetActive(false);
        SurprisedMenu.SetActive(false);
    }

    public void SadMenuButton()
    {
        MainMenus.SetActive(false);
        AngryMenu.SetActive(false);
        BadMenu.SetActive(false);
        DisgustedMenu.SetActive(false);
        FearfulMenu.SetActive(false);
        HappyMenu.SetActive(false);
        SadMenu.SetActive(true);
        SurprisedMenu.SetActive(false);
    }

    public void SurprisedMenuButton()
    {
        MainMenus.SetActive(false);
        AngryMenu.SetActive(false);
        BadMenu.SetActive(false);
        DisgustedMenu.SetActive(false);
        FearfulMenu.SetActive(false);
        HappyMenu.SetActive(false);
        SadMenu.SetActive(false);
        SurprisedMenu.SetActive(true);
    }
}
