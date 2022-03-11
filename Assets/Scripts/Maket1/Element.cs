using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


/// <summary>
/// Скрипт, для настройки Прдмета 
/// </summary>
public class Element : MonoBehaviour
{
    //Изображение Предмета и его Типа 
    [SerializeField] private Sprite ElementImage;
    [SerializeField] private Sprite ElementsType;
   
    //Количество Элементов
    [SerializeField] public float numberElements;
    //Отображение Количества Элементов
    [SerializeField] private TextMeshProUGUI numberElementsText;
    //Компаненты изображений 
    [SerializeField] private Image ImageElement;
    [SerializeField] private Image TypeElement;
    //Отображение Типа Предмета
    [SerializeField] private bool TypeElementVisisble = false;
    void Start()
    {
        TypeElement.sprite = ElementsType;
        ImageElement.sprite = ElementImage;
        CreateRounded();
        if (TypeElementVisisble == true) {
            TypeElement.gameObject.SetActive(true);
        }
        else {
            TypeElement.gameObject.SetActive(false);
        }
    }

    /// <summary>
    /// Отображение Количества предметов, в зависимости от количества 
    /// </summary>
    private void CreateRounded() {
        if (numberElements < 0 && numberElements < 9) {
            numberElementsText.text = "x" + numberElements.ToString();
        }
        else if (numberElements > 10 && numberElements < 999) {
            numberElementsText.text = "x" + numberElements.ToString();
        }
        else if (numberElements > 1000 && numberElements < 99999) {
            int newNumber = (int) numberElements / 1000;
            numberElementsText.text = "x" + newNumber.ToString() + "K";
        }
    }

}
