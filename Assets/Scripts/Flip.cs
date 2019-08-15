using UnityEngine;
using UnityEngine.Assertions;

public class Flip : MonoBehaviour
{
    public float flipSpeed = 1000f;
    public float reverseMod = 1f;

    [System.NonSerialized] public bool isPressed = false;

    private HingeJoint2D hinge;

    private void Awake()
    {
        hinge = GetComponent<HingeJoint2D>();
        Assert.IsNotNull(hinge, "Could'nt find the hinge component!!!"); // will only run in debug mode.
        flipSpeed = 2000f;
    }

    private void FixedUpdate()
    {
        if (isPressed == true)
        {
            JointMotor2D motor = hinge.motor;
            motor.motorSpeed = reverseMod * flipSpeed;
            hinge.motor = motor;
        }
        else
        {
            JointMotor2D motor = hinge.motor;
            motor.motorSpeed = reverseMod * -flipSpeed;
            hinge.motor = motor;
        }
    }
}
