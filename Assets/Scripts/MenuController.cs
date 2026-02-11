using UnityEngine;
using UnityEngine.UIElements;

[RequireComponent(typeof(UIDocument))]
public class MenuController : MonoBehaviour
{
    private const string PLAY_BUTTON_NAME = "Play_Button";
    private const string SETTINGS_BUTTON_NAME = "Settings_Button";
    private const string CREDITS_BUTTON_NAME = "Credits_Button";
    private const string EXIT_BUTTON_NAME = "Exit_Button";
    
    private Button _playButton;
    private Button _settingsButton;
    private Button _creditsButton;
    private Button _exitButton;

    private UIDocument _document;
    private VisualElement _root;

    private void Awake()
    {
        _document = GetComponent<UIDocument>();
        _root = _document.rootVisualElement;

        _playButton.SetupButton(_root, PLAY_BUTTON_NAME, PlayButtonOnClicked);
        _settingsButton.SetupButton(_root, SETTINGS_BUTTON_NAME, SettingsButtonOnClicked);
        _creditsButton.SetupButton(_root, CREDITS_BUTTON_NAME, CreditsButtonOnClicked);
        _exitButton.SetupButton(_root, EXIT_BUTTON_NAME, ExitButtonOnClicked);
    }

    #region ButtonClickFunctions
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
        Application.Quit();
    }
    #endregion

    #region MenuFunctions

    private void FadeMenu()
    {

    }

    #endregion
}