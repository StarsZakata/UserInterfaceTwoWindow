using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/// <summary>
/// ������, ��� ����������� ����������� ���� � ������2 
/// ������������ ����� ��������� ����������� �����������
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
