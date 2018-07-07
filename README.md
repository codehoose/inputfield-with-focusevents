# Input Field with Focus Events
The project contains the following C# scripts.

## InputFieldWithFocusEvents.cs
The replacement for the default Unity InputField class with OnFocus() and OnLostFocus() events. Attach event handlers to those events to be informed when the control gains or loses focus. This logic could also be applied to buttons and other selectable objects.

## InputFieldWithFocusEditor.cs
A blank editor that forces Unity to draw the additional `onFocus` and `onLostFocus` fields. Unity will choose the most appropriate editor for the class. If you derive a class from another and don't provide and editor, Unity will choose the super class' editor for you. It seems that InputField has a custom editor and only draws the fields it wants you to see.

## CreateUiElements.cs
Static class to provide a menu option to easily add the prefab created in the video located in the `Editor Default Resources` folder to a scene.

## ChangeTextLabel.cs
Test class to show that the focus/lost focus events work as expected.