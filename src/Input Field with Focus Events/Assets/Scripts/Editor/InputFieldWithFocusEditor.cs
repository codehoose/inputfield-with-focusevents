using UnityEditor;

[CustomEditor(typeof(InputFieldWithFocusEvents)), CanEditMultipleObjects]
public class InputFieldWithFocusEditor : Editor
{
    // No need to create addition code because the custom inspector finds the
    // most relevant editor for the type, which is this one.
}
