using UnityEngine;
using OVR;

public class JoystickLocomotion : MonoBehaviour
{

    public Rigidbody rb;
    public float speed;

    void Update()
    {
        var joystickAxsis = OVRInput.Get(OVRInput.RawAxis2D.LThumbstick, OVRInput.Controller.LTouch);
        float fixedY = rb.position.y;

        rb.position += (transform.right * joystickAxsis.x + transform.forward * joystickAxsis.y) * Time.deltaTime * speed;
        rb.position = new Vector3(rb.position.x, fixedY, rb.position.z);
    }
}
