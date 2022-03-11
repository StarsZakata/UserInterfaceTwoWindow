using UnityEngine;
using UnityEngine.UI;

public class WindowsController : MonoBehaviour {
    [SerializeField] private Button openWindow1;
    [SerializeField] private Button openWindow2;
    [SerializeField] private Button openMenu;

    [SerializeField] private GameObject window1;
    [SerializeField] private GameObject window2;
    [SerializeField] private GameObject menu;

    //Макеты, для сравнения с полученным результатом 
    [SerializeField] private GameObject ExampleWindow1;
    [SerializeField] private GameObject ExampleWindow2;


    private void Awake() {
        openWindow1.onClick.AddListener(OpenWindow1);
        openWindow2.onClick.AddListener(OpenWindow2);
        openMenu.onClick.AddListener(OpenMenu);
    }

    private void OpenWindow1() {
        window1.SetActive(true);
        ExampleWindow1.SetActive(true);
        openMenu.gameObject.SetActive(true);
        window2.SetActive(false);
        ExampleWindow2.SetActive(false);
        menu.SetActive(false);
    }
    
    private void OpenWindow2() {
        window1.SetActive(false);
        ExampleWindow1.SetActive(false);
        openMenu.gameObject.SetActive(true);
        window2.SetActive(true);
        ExampleWindow2.SetActive(true);
        menu.SetActive(false);
    }
    
    public void OpenMenu() {
        window1.SetActive(false);
        ExampleWindow1.SetActive(false);
        window2.SetActive(false);
        ExampleWindow2.SetActive(false);
        menu.SetActive(true);
        openMenu.gameObject.SetActive(false);
    }
}
