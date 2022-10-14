using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    
    [SerializeField] private WheelJoint2D wheelJoint;
    [SerializeField] private int speed;
    [SerializeField] private int force;
    private JointMotor2D motor;
    private float horizontalInput;
    private float screenWidth;

    private void Start()
    {
        motor = wheelJoint.motor;   
        screenWidth = Screen.width; //Getting the screen width
    }
    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        if (Input.touchCount > 0 && Input.GetTouch(0).position.x > screenWidth / 2)  horizontalInput = 1;          //If player touches right side of screen, bike rides to the right   
        else if (Input.touchCount > 0 && Input.GetTouch(0).position.x < screenWidth / 2)  horizontalInput = -1;    //If player touches left side of screen, bike rides to the left
    }

    private void FixedUpdate()
    {
        motor.maxMotorTorque = force;
        motor.motorSpeed = speed * horizontalInput;
        wheelJoint.motor = motor;
    }   
}
