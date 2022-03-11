using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


/// <summary>
/// Скрипт, для отображения Характеристик Предмета
/// </summary>
public class Parametr : MonoBehaviour
{
    //Перечисление, для удобства выбора типа Характеристики 
    public enum TypeParametr { 
        None=0,
        КритУрон,
        Защита,
        Здоровье,
        КритШанс,
    }
    public TypeParametr ThisParametrType = TypeParametr.None;


    //Изображение для Характеристики 
    [SerializeField]private Sprite ImageParametr;
    //Значение Харакетристики
    [SerializeField] private float value;

    //Текстовые Объекты для отображения типа Характеристики и Значения
    [SerializeField] private TextMeshProUGUI DataParametr;
    [SerializeField] private TextMeshProUGUI ValueParametr;
    void Start()
    {
        gameObject.transform.GetChild(0).GetComponent<Image>().sprite = ImageParametr;
        DataParametr.text = ThisParametrType.ToString() + ":";
        ValueParametr.text = "+" + value.ToString()+"%";
    }
}
