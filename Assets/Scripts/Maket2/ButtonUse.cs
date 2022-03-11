using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/// <summary>
/// Скрипт, для Интерактивности Кнопки 
/// </summary>
public class ButtonUse : MonoBehaviour
{
	[SerializeField] private Image Check;

	private bool CheckUse = false;
	public void InsertCheckUse()
	{
		if (CheckUse == false)
		{
			Check.gameObject.SetActive(true);
			CheckUse = true;
		}
		else if(CheckUse == true)
		{
			Check.gameObject.SetActive(false);
			CheckUse = false;
		}

	}
}
