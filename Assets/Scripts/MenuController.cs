using UnityEngine;
using UnityEngine.UIElements;

public class MenuController : MonoBehaviour
{
    private UIDocument _document;
    private VisualElement _root;
    private Button _playButton;
    private Button _settingsButton;
    private Button _creditsButton;
    private Button _exitButton;

    private void Awake()
    {
        _document = GetComponent<UIDocument>();
        _root = _document.rootVisualElement;
        
        _playButton = _root.SetupButton("Play_Button",PlayButtonOnClicked);
        _settingsButton  = _root.SetupButton("Settings_Button",SettingsButtonOnClicked);
        _creditsButton = _root.SetupButton("Credits_Button",CreditsButtonOnClicked);
        _exitButton = _root.SetupButton("Exit_Button",ExitButtonOnClicked);
    }

    #region ButtonClickFunctions
    private static void PlayButtonOnClicked(MouseDownEvent evt)
    {
        Debug.Log("Play Clicked");
        // SceneManager.LoadScene("Demo_URP");
    }

    private static void SettingsButtonOnClicked(MouseDownEvent evt)
    {
        Debug.Log("Settings Clicked");
    }

    private static void CreditsButtonOnClicked(MouseDownEvent evt)
    {
        Debug.Log("Credits Clicked");
    }

    private static void ExitButtonOnClicked(MouseDownEvent evt)
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