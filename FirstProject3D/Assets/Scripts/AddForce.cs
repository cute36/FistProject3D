using UnityEngine;

public class AddForce:MonoBehaviour
{
    private Rigidbody _rigidbody;
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            _rigidbody.AddForce(-15f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            _rigidbody.AddForce(15f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.W))
        {
            _rigidbody.AddForce(0f, 0f, 15f);
        }
        if(Input.GetKey(KeyCode.S))
        {
            _rigidbody.AddForce(0f, 0f, -15f);
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody.AddForce(Vector3.up * 5f, ForceMode.VelocityChange);
        }


    }
}
