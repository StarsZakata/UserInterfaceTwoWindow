using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/// <summary>
/// Скрипт, для корректного подложки уровня Персонажа
/// В зависимости от уровня 
/// </summary>
public class ControllMaskLevel : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI ValueLevelMask;
    [SerializeField] private Image MaskLevel;


    private float sizeMask;
    private int level;
    void Start()
    {
        //Исключение, в случаи если задано 0(null) 
        try
        {
            level = System.Int32.Parse(ValueLevelMask.text);
        }
        catch {
            MaskLevel.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 0);
        }
        if (level < 9) {
            MaskLevel.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, sizeMask / 3);
        }
        if (level > 10 && level < 99) {
            MaskLevel.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, sizeMask / 2);
        }
        if (level > 100 && level < 99) {
            MaskLevel.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, sizeMask);
        }
    }


}
