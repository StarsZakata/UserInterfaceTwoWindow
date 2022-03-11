using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/// <summary>
/// ������, ��� ��������� ��������� 
/// </summary>
public class Person : MonoBehaviour
{
	//��������� ����������� ����, �������, �����, ����� 
	[SerializeField] private Sprite[] ImageBackground;
	[SerializeField] private Sprite[] TypePerson;
	[SerializeField] private Sprite[] TypeHero;
	[SerializeField] private Sprite[] TypeStar;

	//������������ ��� ����, �������, ����� 
	public enum TypeBackground
	{
		None = 0,
		�������,
		�������,
		������,
		����������,
		�����,
	}
	public TypeBackground ThisBackgroundType = TypeBackground.None;
	public enum TypePersons
	{
		None = 0,
		������,
		�����,
		����,
		�����,
		����,
		��
	}
	public TypePersons ThisPesronType = TypePersons.None;
	public enum HeroImage{
		None=0,
		���,
		���,
		������,
	}
	public HeroImage ThisHeroType = HeroImage.None;

	//����������� ����, �������, �����
	Image Background;
	Image Type;
	Image Hero;

	//���������� ����� ���������
	[Range(0,5)]
	[SerializeField] private int value = 0;
	//������� ���������
	[SerializeField] private int LevelPerson = 0;
	//���������� ���������, ��� ���� �������� ������ � ������� �����
	[SerializeField] private bool Voznecenie = false;
	//�������� ����������
	[SerializeField] private int VoznecenieValue = 0;

	//����������, ��� �������� ���������� �����
	[SerializeField] private float sizeMask = 0;
	public Image MaskStarts;
	public Image StarImage;

	public Image VoznecenieImage;

	//����������� ������ ���� ������, ���� ���������� 
	[SerializeField] private TextMeshProUGUI ValueVoznecenie;
	[SerializeField] private TextMeshProUGUI ValueLevel;

	//������������ ��� ��������������� ����������� ����� � �����
	public enum NoneShadowLight { 
		None=0,
		Shadow,
		Light
	}
	public NoneShadowLight TypeShadowLight = NoneShadowLight.None;
	[SerializeField] private Image ShadowImage;
	[SerializeField] private Image LightImage;

	/// <summary>
	/// ���������� ��������� � ������� ��������������� ������
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
	/// ������ ��� ��������� ���������
	/// </summary>
	private void Start()
    {

		InsertBackgroundAndStars();
		InsertTypePesron();

		InsertHero();

		InsertShadowLight();

	}
	/// <summary>
	/// ��������� ���� ��� �����
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
	/// ��������� ������� ��������� 
	/// </summary>
	private void InsertTypePesron() {
		switch (ThisPesronType) {
			case TypePersons.������:
				Type.sprite = TypePerson[0];
				break;
			case TypePersons.�����:
				Type.sprite = TypePerson[1];
				break;
			case TypePersons.����:
				Type.sprite = TypePerson[2];
				break;
			case TypePersons.�����:
				Type.sprite = TypePerson[3];
				break;
			case TypePersons.����:
				Type.sprite = TypePerson[4];
				break;
			case TypePersons.��:
				Type.sprite = TypePerson[5];
				break;
		}
	}

	/// <summary>
	/// ��������� ���������� ���������
	/// </summary>
	private void SetVoznecenie()
	{
		VoznecenieImage.gameObject.SetActive(true);
		StarImage.gameObject.SetActive(false);
	}

	/// <summary>
	/// ����������� ���� ����� � �� ���������� 
	/// </summary>
	private void InsertBackgroundAndStars() {
		switch (ThisBackgroundType){
			case TypeBackground.�������:
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
			case TypeBackground.�������:
				Background.sprite = ImageBackground[1];

				StarImage.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 117f);
				StarImage.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 26f);
				sizeMask = StarImage.rectTransform.rect.width;


				MaskStarts.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, sizeMask / 5 * value);

				StarImage.sprite = TypeStar[2];
				break;
			case TypeBackground.������:
				Background.sprite = ImageBackground[2];

				StarImage.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal,50f);
				StarImage.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 27f);
				sizeMask = StarImage.rectTransform.rect.width;


				MaskStarts.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, sizeMask / 2 * value);

				StarImage.sprite = TypeStar[5];

				break;
			case TypeBackground.����������:
				Background.sprite = ImageBackground[3];

				StarImage.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 96f);
				StarImage.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 26f);
				sizeMask = StarImage.rectTransform.rect.width;


				MaskStarts.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, sizeMask / 4 * value);

				StarImage.sprite = TypeStar[3];
				break;
			case TypeBackground.�����:
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
	/// ��������� ����� 
	/// </summary>
	private void InsertHero() {
		switch (ThisHeroType) {
			case HeroImage.���:
				Hero.sprite = TypeHero[0];
				break;
			case HeroImage.���:
				Hero.sprite = TypeHero[1];
				break;
			case HeroImage.������:
				Hero.sprite = TypeHero[2];
				break;
		}
	}

}
