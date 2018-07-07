using UnityEngine.Events;
using UnityEngine.UI;

public class InputFieldWithFocusEvents : InputField
{
    // Cache the last value of the 'isFocused' field
    private bool _lastFocused;

    // Lost focus event. 
    public UnityEvent onLostFocus;

    // Got focus event.
    public UnityEvent onFocus;

    protected override void Awake()
    {
        // Call the base class to setup the input field / selectable classes
        base.Awake();

        // Cache the current version of 'isFocused'
        _lastFocused = isFocused;
    }    

    void Update()
    {
        // Check to see if the current focus has shifted from the control. If it 
        // has, call the appropriate event's subscribers
        if (_lastFocused != isFocused)
        {
            _lastFocused = isFocused;

            if (isFocused)
            {
                // This will call all subscribers to inform them ctrl has focus
                onFocus.Invoke();
            }
            else
            {
                // This will call all subscribers to inform them ctrl has lost focus
                onLostFocus.Invoke();
            }
        }
    }
}
