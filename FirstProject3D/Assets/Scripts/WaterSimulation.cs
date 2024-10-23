using UnityEngine;

public class WaterSimulation : MonoBehaviour
{
    public float WaterDensity = 10f;
    private Rigidbody _rigidbody;
    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    
    void fixedUpdate()
    {
        float divePercent = - transform.position.y + transform.localScale.x *5f;
        divePercent = Mathf.Clamp(divePercent, 0f, 1f);

        _rigidbody.AddForce(Vector3.up * divePercent * WaterDensity);
        _rigidbody.linearDamping = divePercent * 2f;
        _rigidbody.angularDamping = divePercent * 2f;
    }
}
