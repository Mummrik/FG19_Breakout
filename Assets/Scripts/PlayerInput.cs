using UnityEngine;
using UnityEngine.Assertions;

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
    public Flip leftFlipper;
    public Flip rightFlipper;

    private const string leftFlipperName = "LeftFlipper";
    private const string rightFlipperName = "RightFlipper";

    #region Unity methods
    //Functions/Methods
    //Access modifier, return datatype, method name, parameters
    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = false;
        playerCamera = Camera.main; // Camera.main uses find object whit tag internally, super rude.
        leftFlipper = GetFlipper(leftFlipperName);
        Assert.IsNotNull(leftFlipper, string.Format("Child: {0} was not found!", leftFlipperName));
        rightFlipper = GetFlipper(rightFlipperName);
        Assert.IsNotNull(rightFlipper, string.Format("Child: {0} was not found!", rightFlipperName));
    }

    private void OnDestroy()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    private void Update()
    {
        float xPosition = playerCamera.ScreenToWorldPoint(Input.mousePosition).x;
        transform.position = new Vector3(xPosition, transform.position.y, transform.position.z);

        leftFlipper.isPressed = Input.GetMouseButton(0);
        rightFlipper.isPressed = Input.GetMouseButton(1);
    }
    #endregion Unity methods

    //private Flip GetFlipper(Input input)
    private Flip GetFlipper(string flipperName)
    {
        //Transform flipperTransfrom = transform.Find(flipperName);
        //Assert.IsNotNull(flipperTransfrom, string.Format("Child: {0} was not found!", flipperName));
        //Flip flipper = flipperTransfrom.GetComponent<Flip>();
        //Assert.IsNotNull(flipper, string.Format("Child: {0} missing Flip script!", flipperName));

        return transform.Find(flipperName)?.GetComponent<Flip>();
    }

}
