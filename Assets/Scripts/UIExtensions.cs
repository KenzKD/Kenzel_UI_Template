using System;
using UnityEngine;
using UnityEngine.UIElements;

public static class UIExtensions
{
    private static T SetupElement<T, TEvent>(this VisualElement uiRoot, string elementName, EventCallback<TEvent> eventHandler, TrickleDown trickleDown = TrickleDown.NoTrickleDown , bool doLogging = false) 
        where T : VisualElement, new()
        where TEvent : EventBase<TEvent>, new()
    {
        string setupDetails= $"{eventHandler.Method.DeclaringType?.Name}.{eventHandler.Method.Name} → {typeof(T).Name} '{elementName}'";
        
        if (uiRoot == null) throw new ArgumentNullException( nameof(uiRoot), $"<b><i><color=red>Registration FAILED</color></i></b>\n{setupDetails}\t<color=yellow>UI root is null</color>");
        T element = uiRoot.Q<T>(elementName);
        
        if (element == null) throw new ArgumentNullException( nameof(element), $"<b><i><color=red>Registration FAILED</color></i></b>\n{setupDetails}\t<color=yellow>Element '{elementName}' not found in the UI document</color>");
        element.RegisterCallback(eventHandler, trickleDown);
        
        if (doLogging) Debug.Log($"<b><i><color=green>Registration SUCCESS</color></i></b>\n{setupDetails}");
        return element;
    }
    
    public static Button SetupButton(this VisualElement uiRoot, string buttonName, EventCallback<MouseDownEvent> clickHandler)
    {
        return uiRoot.SetupElement<Button,MouseDownEvent>(buttonName, clickHandler,TrickleDown.TrickleDown,true);
    }
}
