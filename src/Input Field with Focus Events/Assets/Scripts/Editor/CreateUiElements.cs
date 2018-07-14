using UnityEditor;
using UnityEngine;

public static class CreateUiElements
{
    // Add a new menu to the Unity editor to load the focusable input field 
    [MenuItem("GameObject/UI/Input Field (Focus)", false)]
    public static void AddInputFieldWithFocusEvents()
    {
        // Load the prefab into memory from the special "Editor Default Resources" folder
        var prefab = (GameObject)EditorGUIUtility.Load("InputFieldWithFocus.prefab");

        // Make a copy of the prefab
        var copy = GameObject.Instantiate(prefab);

        // Attach it to the parent object - if there is one selected
        if (Selection.activeGameObject != null)
        {
            copy.transform.SetParent(Selection.activeGameObject.transform);
            copy.transform.localPosition = Vector3.zero;
        }
    }
}
