using UnityEngine;

public class joystickTurn : MonoBehaviour
{

    public Rigidbody rb;
    public Transform rotation;
    public float speed;

    void Update()
    {
        var joystickAxsis = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick, OVRInput.Controller.RTouch);

        if (joystickAxsis.x >= 0.6f)
        {
            rb.transform.RotateAround(rotation.position, rotation.up, speed * .1f);
        }
        if (joystickAxsis.x <= -0.6f)
        {
            rb.transform.RotateAround(rotation.position, rotation.up, speed * -.1f);
        }

    }
}
