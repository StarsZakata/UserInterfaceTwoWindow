using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/// <summary>
/// ������, ��� ��������� ������� ��������
/// � ����������� �� ����������� ��������� 
/// </summary>
public class BuilderNumberElement : MonoBehaviour
{
	//������, � �������� ����� ����� 
	[SerializeField] private Element Elements;


	private float number;
	private RectTransform thisRectTransform;
	private void Start()
	{
		thisRectTransform = gameObject.GetComponent<RectTransform>();
		number = Elements.numberElements;

		if (number < 9)
		{
			thisRectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 50);
		}
		else if (number > 10 && number < 99)
		{
			thisRectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 75);
		}
		else if (number > 100) {
			thisRectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 100);
		}

	}

}
