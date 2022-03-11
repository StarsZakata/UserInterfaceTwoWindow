using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Скрипт, для отображения Одного или Двух 
/// Персонажей требуемых для Возвышения 
/// </summary>
public class NeedPerson : MonoBehaviour
{
    //Количество Персонажей 
    [SerializeField] private bool TwoPerson;

    [SerializeField] private GameObject PrefabPerson;
    //Позиции Персонажей 
    [SerializeField] private RectTransform PointOne;
    [SerializeField] private RectTransform PointTwo;
    private void Start()
    {
        if (TwoPerson == true) {
            GameObject OnePerson = Instantiate(PrefabPerson, PointOne.gameObject.transform.position, Quaternion.identity, transform);
            GameObject TwoPerson = Instantiate(PrefabPerson, PointTwo.gameObject.transform.position, Quaternion.identity, transform);
        }
        else if (TwoPerson == false) {
            GameObject OnePerson = Instantiate(PrefabPerson, gameObject.transform.position, Quaternion.identity, transform);
        }
    }

}
