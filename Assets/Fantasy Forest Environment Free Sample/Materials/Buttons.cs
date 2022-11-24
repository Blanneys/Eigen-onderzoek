using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Buttons : MonoBehaviour
{
    public GameObject _submenu;
    public void OnPointerClick(PointerEventData pointerEventData)
    {
        if (pointerEventData.button == PointerEventData.InputButton.Middle)
        {
            gameObject.SetActive(false);
            _submenu.SetActive(true);
            Debug.Log(_submenu);
        }
    }

}
