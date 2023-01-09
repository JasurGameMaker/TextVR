using UnityEngine;
using OVR;

public class JoystickLocomotion : MonoBehaviour
{

    public Rigidbody rb;
    public float speed;

    void Update()
    {
        var joystickAxsis = OVRInput.Get(OVRInput.RawAxis1D.LIndexTrigger, OVRInput.Controller.LTouch);
        float fixedY = rb.position.y;

        rb.position += (transform.forward * joystickAxsis) * Time.deltaTime * speed;
        rb.position = new Vector3(rb.position.x, fixedY, rb.position.z);
    }
}
