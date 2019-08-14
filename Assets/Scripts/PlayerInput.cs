using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    #region Data types and variables
    // Creating a variable
    // access modifier - ata type - variable name

    // access modifiers: public, private protected
    // if no access modifier it is private
    //public int myValue1;        // Declaring a variable.
    //public int myValue2 = 10;   // Declaring and initializing the variable. This is a member variable.
    //public int myOtherValue { get; protected set; } // This equals something similar to a private variable, but other classes can only access/get the value but not change/set the value.

    //private float speed = 10.5f; // 10.0f = 10f
    //private double precisionSpeed = 10.5f;
    //private string myName = "Jocke";
    //private char myChar = 'c';

    /* Primitive Data types
        int = whole numbers
        bool = true or false
        float = decimals ~7 decimals
        double = decimals   ~15 decimals
        string = text or a string of characters
        char = one character
     */
    #endregion Data types and variables

    private Camera playerCamera;

    //Functions/Methods
    //Access modifier, return datatype, method name, parameters
    private void Awake()
    {
        playerCamera = Camera.main; // Camera.main uses find object whit tag internally, super rude.
    }

}
