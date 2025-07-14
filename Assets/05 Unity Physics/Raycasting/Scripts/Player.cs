using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    public float radius = 5.0f;
    public float power = 1000.0f;
    public float kickStrength = 500.0f;

    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        controller.detectCollisions = false;
    }

    void Update()
    {
        CheckExplosion();
        CheckKick();
        MovePlayer();
    }

    void MovePlayer()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 move = transform.right * h + transform.forward * v;
        controller.Move(move * speed * Time.deltaTime);
    }

    void CheckExplosion()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Collider[] colliders = Physics.OverlapSphere(transform.position, radius);
            foreach (Collider hit in colliders)
            {
                Rigidbody rb = hit.GetComponent<Rigidbody>();
                if (rb != null)
                {
                    rb.AddExplosionForce(power, transform.position, radius);
                }
            }
        }
    }

    void CheckKick()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddForce(transform.forward * kickStrength);
            }
        }
    }
}
