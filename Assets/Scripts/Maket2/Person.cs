using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/// <summary>
/// Скрипт, для настройки Персонажа 
/// </summary>
public class Person : MonoBehaviour
{
	//Возможные изображения Фона, Фракции, Героя, Звезд 
	[SerializeField] private Sprite[] ImageBackground;
	[SerializeField] private Sprite[] TypePerson;
	[SerializeField] private Sprite[] TypeHero;
	[SerializeField] private Sprite[] TypeStar;

	//Перечисления для Фона, Фракции, Героя 
	public enum TypeBackground
	{
		None = 0,
		Золотой,
		Красный,
		Зелёный,
		Фиолетовый,
		Синий,
	}
	public TypeBackground ThisBackgroundType = TypeBackground.None;
	public enum TypePersons
	{
		None = 0,
		Восток,
		Запад,
		Свет,
		Север,
		Тень,
		Юг
	}
	public TypePersons ThisPesronType = TypePersons.None;
	public enum HeroImage{
		None=0,
		Маг,
		Вор,
		Рыцарь,
	}
	public HeroImage ThisHeroType = HeroImage.None;

	//Изображение Фона, Фракции, Героя
	Image Background;
	Image Type;
	Image Hero;

	//Количество Звезд Персонажа
	[Range(0,5)]
	[SerializeField] private int value = 0;
	//Уровень Персонажа
	[SerializeField] private int LevelPerson = 0;
	//Вознесение Персонажа, при этом работает только с Золотым Фоном
	[SerializeField] private bool Voznecenie = false;
	//Значение вознесения
	[SerializeField] private int VoznecenieValue = 0;

	//Переменные, для контроля количества звезд
	[SerializeField] private float sizeMask = 0;
	public Image MaskStarts;
	public Image StarImage;

	public Image VoznecenieImage;

	//Отображение текста либо Уровня, либо Вознесения 
	[SerializeField] private TextMeshProUGUI ValueVoznecenie;
	[SerializeField] private TextMeshProUGUI ValueLevel;

	//Перечисление для Вспомогательный изображений Света и Тениы
	public enum NoneShadowLight { 
		None=0,
		Shadow,
		Light
	}
	public NoneShadowLight TypeShadowLight = NoneShadowLight.None;
	[SerializeField] private Image ShadowImage;
	[SerializeField] private Image LightImage;

	/// <summary>
	/// Нахождение элементов и вставка первоночального уровня
	/// </summary>
	private void Awake()
	{
		Hero = transform.GetChild(0).GetComponent<Image>();
		
		Type = transform.GetChild(2).GetComponent<Image>();
		
		Background = GetComponent<Image>();

		VoznecenieImage.gameObject.SetActive(false);
		if (LevelPerson == 0) {
			ValueLevel.text = null;
		}
		else{
			ValueLevel.text = LevelPerson.ToString();
		}
	}
	/// <summary>
	/// Методы для настрйоки Персонажа
	/// </summary>
	private void Start()
    {

		InsertBackgroundAndStars();
		InsertTypePesron();

		InsertHero();

		InsertShadowLight();

	}
	/// <summary>
	/// Настройка Тьмы или Света
	/// </summary>
	private void InsertShadowLight() {
		switch (TypeShadowLight) {
			case NoneShadowLight.Shadow:
				ShadowImage.gameObject.SetActive(true);
				break;
			case NoneShadowLight.Light:
				LightImage.gameObject.SetActive(true);
				break;
		}
	}

	/// <summary>
	/// Настройка Фракции Персонажа 
	/// </summary>
	private void InsertTypePesron() {
		switch (ThisPesronType) {
			case TypePersons.Восток:
				Type.sprite = TypePerson[0];
				break;
			case TypePersons.Запад:
				Type.sprite = TypePerson[1];
				break;
			case TypePersons.Свет:
				Type.sprite = TypePerson[2];
				break;
			case TypePersons.Север:
				Type.sprite = TypePerson[3];
				break;
			case TypePersons.Тень:
				Type.sprite = TypePerson[4];
				break;
			case TypePersons.Юг:
				Type.sprite = TypePerson[5];
				break;
		}
	}

	/// <summary>
	/// Настройка вознесения Персонажа
	/// </summary>
	private void SetVoznecenie()
	{
		VoznecenieImage.gameObject.SetActive(true);
		StarImage.gameObject.SetActive(false);
	}

	/// <summary>
	/// Отображения типа Звезд и из количества 
	/// </summary>
	private void InsertBackgroundAndStars() {
		switch (ThisBackgroundType){
			case TypeBackground.Золотой:
				Background.sprite = ImageBackground[0];


				if (Voznecenie == false)
				{
					StarImage.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 117f);
					StarImage.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 26f);
					sizeMask = StarImage.rectTransform.rect.width;


					MaskStarts.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, sizeMask / 5 * value);
					StarImage.sprite = TypeStar[1];
				}
				else if (Voznecenie == true) {
					SetVoznecenie();
					ValueVoznecenie.text = VoznecenieValue.ToString();
				}

				break; 
			case TypeBackground.Красный:
				Background.sprite = ImageBackground[1];

				StarImage.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 117f);
				StarImage.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 26f);
				sizeMask = StarImage.rectTransform.rect.width;


				MaskStarts.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, sizeMask / 5 * value);

				StarImage.sprite = TypeStar[2];
				break;
			case TypeBackground.Зелёный:
				Background.sprite = ImageBackground[2];

				StarImage.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal,50f);
				StarImage.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 27f);
				sizeMask = StarImage.rectTransform.rect.width;


				MaskStarts.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, sizeMask / 2 * value);

				StarImage.sprite = TypeStar[5];

				break;
			case TypeBackground.Фиолетовый:
				Background.sprite = ImageBackground[3];

				StarImage.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 96f);
				StarImage.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 26f);
				sizeMask = StarImage.rectTransform.rect.width;


				MaskStarts.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, sizeMask / 4 * value);

				StarImage.sprite = TypeStar[3];
				break;
			case TypeBackground.Синий:
				Background.sprite = ImageBackground[4];

				StarImage.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 74f);
				StarImage.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 27f);
				sizeMask = StarImage.rectTransform.rect.width;


				MaskStarts.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, sizeMask / 3 * value);

				StarImage.sprite = TypeStar[4];
				break;
		}
	}

	/// <summary>
	/// Настрйока Героя 
	/// </summary>
	private void InsertHero() {
		switch (ThisHeroType) {
			case HeroImage.Маг:
				Hero.sprite = TypeHero[0];
				break;
			case HeroImage.Вор:
				Hero.sprite = TypeHero[1];
				break;
			case HeroImage.Рыцарь:
				Hero.sprite = TypeHero[2];
				break;
		}
	}

}
