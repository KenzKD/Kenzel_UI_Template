using UnityEngine;
using UnityEngine.UIElements;

[RequireComponent(typeof(UIDocument))]
public class GraphicSettingsController : MonoBehaviour
{
    private const string BACK_BUTTON_NAME = "Back_Button";
    private Button _backButton;
    
    private UIDocument _document;
    private VisualElement _root;

    private void Awake()
    {
        _document = GetComponent<UIDocument>();
        _root = _document.rootVisualElement;

        _backButton.SetupButton(_root, BACK_BUTTON_NAME, BackButtonOnClicked);
    }

    private static void BackButtonOnClicked()
    {
        Debug.Log("Back Clicked");
        // Application.Quit();
    }
}