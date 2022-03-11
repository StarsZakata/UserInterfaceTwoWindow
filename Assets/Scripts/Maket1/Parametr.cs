using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


/// <summary>
/// ������, ��� ����������� ������������� ��������
/// </summary>
public class Parametr : MonoBehaviour
{
    //������������, ��� �������� ������ ���� �������������� 
    public enum TypeParametr { 
        None=0,
        ��������,
        ������,
        ��������,
        ��������,
    }
    public TypeParametr ThisParametrType = TypeParametr.None;


    //����������� ��� �������������� 
    [SerializeField]private Sprite ImageParametr;
    //�������� ��������������
    [SerializeField] private float value;

    //��������� ������� ��� ����������� ���� �������������� � ��������
    [SerializeField] private TextMeshProUGUI DataParametr;
    [SerializeField] private TextMeshProUGUI ValueParametr;
    void Start()
    {
        gameObject.transform.GetChild(0).GetComponent<Image>().sprite = ImageParametr;
        DataParametr.text = ThisParametrType.ToString() + ":";
        ValueParametr.text = "+" + value.ToString()+"%";
    }
}
