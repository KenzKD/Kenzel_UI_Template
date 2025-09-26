using UnityEngine.UIElements;

public static class UIExtensions
{
    public static void RegisterClickEvent(this Button button, EventCallback<MouseDownEvent> callback)
    {
        button?.RegisterCallback(callback, TrickleDown.TrickleDown);
    }
}
