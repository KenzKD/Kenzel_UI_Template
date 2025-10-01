using UnityEngine;
using UnityEngine.UIElements;

public class GraphicSettingsController : MonoBehaviour
{
    private UIDocument _document;
    private VisualElement _root;
    private Button _backButton;

    private void Awake()
    {
        _document = GetComponent<UIDocument>();
        _root = _document.rootVisualElement;
        
        _backButton = _root.SetupButton("Back_Button",BackButtonOnClicked);
    }

    private static void BackButtonOnClicked(MouseDownEvent evt)
    {
        Debug.Log("Back Clicked");
        // Application.Quit();
    }
}