using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float torqueAmount = 300.0f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
            rb.AddTorque(Vector3.up * torqueAmount, ForceMode.Impulse);

        if (Input.GetKeyDown(KeyCode.X))
            rb.AddTorque(Vector3.down * torqueAmount, ForceMode.Impulse);
    }
}
