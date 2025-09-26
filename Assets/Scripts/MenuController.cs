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
        
        _playButton = _root.Q<Button>("Play_Button");
        _playButton.RegisterClickEvent(PlayButtonOnClicked);
        
        _settingsButton = _root.Q<Button>("Settings_Button");
        _settingsButton.RegisterClickEvent(SettingsButtonOnClicked);
        
        _creditsButton = _root.Q<Button>("Credits_Button");
        _creditsButton.RegisterClickEvent(CreditsButtonOnClicked);
        
        _exitButton = _root.Q<Button>("Exit_Button");
        _exitButton.RegisterClickEvent(ExitButtonOnClicked);
    }
    
    

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
        // Application.Quit();
    }
}