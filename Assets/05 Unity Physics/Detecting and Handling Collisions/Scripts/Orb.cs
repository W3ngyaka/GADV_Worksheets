using UnityEngine;

public class Orb : MonoBehaviour
{
    public float impulseStrength = 10f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
             rb.AddForce(Vector3.forward * impulseStrength, ForceMode.Impulse);
        }
    }
}
