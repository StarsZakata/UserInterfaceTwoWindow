using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/// <summary>
/// Скрипт, для очередности изображений фона в Макете2 
/// Осуществялем через изменение АльфаКанала изображения
/// </summary>
public class PanelBackground : MonoBehaviour
{
    [SerializeField] private bool BackGround;
    [SerializeField] private Image AlfaCanalBackground;
    void Start()
    {
        AlfaCanalBackground = gameObject.GetComponent<Image>();
        if (BackGround == true)
        {
            Color c = gameObject.GetComponent<Image>().color;
            c.a = 0x00;
            AlfaCanalBackground.color = c;
        }
        else if (BackGround == false)
        {

        }
    }
}
