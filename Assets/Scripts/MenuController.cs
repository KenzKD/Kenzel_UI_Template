using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MenuController : MonoBehaviour
{
    private UIDocument _document;
    private Button _playButton;
    private Button _settingsButton;
    private Button _creditsButton;
    private Button _exitButton;

    private void Awake()
    {
        _document = GetComponent<UIDocument>();
        _playButton = _document.rootVisualElement.Q<Button>("Play_Button");
        _settingsButton = _document.rootVisualElement.Q<Button>("Settings_Button");
        _creditsButton = _document.rootVisualElement.Q<Button>("Credits_Button");
        _exitButton = _document.rootVisualElement.Q<Button>("Exit_Button");

        _playButton.clicked += PlayButtonOnClicked;
        // _playButton.RegisterCallback<ClickEvent>(PlayButtonOnClicked);
        _settingsButton.clicked += SettingsButtonOnClicked;
        _creditsButton.clicked += CreditsButtonOnClicked;
        _exitButton.clicked += ExitButtonOnClicked;
    }

    private static void PlayButtonOnClicked()
    {
        Debug.Log("Play Clicked");
        // SceneManager.LoadScene("Demo_URP");
    }

    private static void SettingsButtonOnClicked()
    {
        Debug.Log("Settings Clicked");
    }

    private static void CreditsButtonOnClicked()
    {
        Debug.Log("Credits Clicked");
    }

    private static void ExitButtonOnClicked()
    {
        Debug.Log("Exit Clicked");
        // Application.Quit();
    }
}