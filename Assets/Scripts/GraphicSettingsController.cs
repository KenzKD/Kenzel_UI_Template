using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class GraphicSettingsController : MonoBehaviour
{
    private UIDocument _document;
    private Button _backButton;

    private void Awake()
    {
        _document = GetComponent<UIDocument>();
        _backButton = _document.rootVisualElement.Q<Button>("Back_Button");

        _backButton.clicked += BackButtonOnClicked;
    }

    private void BackButtonOnClicked()
    {
        Debug.Log("Back Clicked");
        // Application.Quit();
    }
}