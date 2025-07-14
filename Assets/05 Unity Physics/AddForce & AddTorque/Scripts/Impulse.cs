using UnityEngine;

public class Impulse : MonoBehaviour
{
    public float forceAmount = 300.0f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
            rb.AddForce(Vector3.forward * forceAmount, ForceMode.Impulse);

        if (Input.GetKeyDown(KeyCode.DownArrow))
            rb.AddForce(Vector3.back * forceAmount, ForceMode.Impulse);

        if (Input.GetKeyDown(KeyCode.LeftArrow))
            rb.AddForce(Vector3.left * forceAmount, ForceMode.Impulse);

        if (Input.GetKeyDown(KeyCode.RightArrow))
            rb.AddForce(Vector3.right * forceAmount, ForceMode.Impulse);

        if (Input.GetKeyDown(KeyCode.Space))
            rb.AddForce(Vector3.up * forceAmount, ForceMode.Impulse);
    }
}
