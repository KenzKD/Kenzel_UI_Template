using UnityEngine;
using UnityEngine.UIElements;

[RequireComponent(typeof(UIDocument))]
public class GraphicSettingsController : MonoBehaviour
{
    private const string BACK_BUTTON_NAME = "Back_Button";
    private Button _backButton;
    
    private UIDocument _document;
    private VisualElement _root;
    private VisualElement _mainMenuContainer;
    private VisualElement _settingsContainer;

    private void Awake()
    {
        _document = GetComponent<UIDocument>();
        _root = _document.rootVisualElement;
        
        _mainMenuContainer = _root.Q<VisualElement>("Main_Menu_Container");
        
        _settingsContainer = _root.Q<VisualElement>("Settings_Menu_Container");
        _settingsContainer.style.display = DisplayStyle.None;
        
        _backButton.SetupButton(_root, BACK_BUTTON_NAME, BackButtonOnClicked);
    }

    private void BackButtonOnClicked()
    {
        Debug.Log("Back Clicked");
        _settingsContainer.style.display = DisplayStyle.None;
        _mainMenuContainer.style.display = DisplayStyle.Flex;   
        // Application.Quit();
    }
}