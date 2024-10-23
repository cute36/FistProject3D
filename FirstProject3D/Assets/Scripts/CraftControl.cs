using UnityEngine;

public class CraftControl : MonoBehaviour
{
    private Rigidbody _rigidbody;
    public float speed = 5f;
    public float rotationSpeed = 1f;

    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.maxAngularVelocity = Mathf.Infinity;
    }

    void FixedUpdate()
    {
        float slideForce = Input.GetAxis("Horizontal") * rotationSpeed;
        float forwardForce = Input.GetAxis("Vertical") * speed;

        _rigidbody.AddRelativeForce(-forwardForce, 0f, 0f);
        _rigidbody.AddRelativeTorque(0f, slideForce, 0f);
        if (Input.GetKey(KeyCode.Space))
        {
            _rigidbody.AddForce(Vector3.up * 10f, ForceMode.Acceleration);
        }
        if (Input.GetKey(KeyCode.LeftControl))
        {
            _rigidbody.AddForce(Vector3.up * -10f, ForceMode.Acceleration);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            _rigidbody.AddRelativeForce(-10f, 0f,0f, ForceMode.Acceleration);
        }
    }
}
