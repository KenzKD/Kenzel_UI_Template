using System;
using UnityEngine.UIElements;

public static class UIExtensions
{
    public static void SetupButton(this Button button, VisualElement uiRoot, string buttonName, Action action)
    {
        if (uiRoot == null)
        {
            throw new ArgumentNullException(nameof(uiRoot), $"<b><i><color=red>Registration FAILED</color></i></b>\n\t<color=yellow>UI root is null</color>");
        }

        if (string.IsNullOrEmpty(buttonName))
        {
            throw new ArgumentException($"<b><i><color=red>Registration FAILED</color></i></b>\n\t<color=yellow>Button name is Null or Empty</color>", nameof(buttonName));
        }

        button = uiRoot.Q<Button>(buttonName);
        button.clicked += action;
    }
}
