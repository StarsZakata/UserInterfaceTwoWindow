using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// ��������� ���, ��� ���������������� ������ � ������1 
/// </summary>
public class Window1 : MonoBehaviour
{
    [SerializeField] private WindowsController conrollerSceneWindow;

    public void CloseAndUseWindow()
    {
        conrollerSceneWindow.OpenMenu();
    }
}
