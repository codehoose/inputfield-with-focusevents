using UnityEngine;
using UnityEngine.UI;

// Debug class. Not part of the actual solution to the problem.
public class ChangeTextLabel : MonoBehaviour
{
    Text _text;

    void Awake()
    {
        _text = GetComponent<Text>();
    }

    // Event handler for text field getting focus
    public void GotFocus()
    {
        _text.text = "Got focus!";
        
    }

    // Event handler for text field losing focus
    public void LostFocus()
    {
        _text.text = "Lost focus :(";
    }
}
