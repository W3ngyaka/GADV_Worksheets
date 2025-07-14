using UnityEngine;

public class CosmicCube : MonoBehaviour
{
    private Renderer rend;
    private Color originalColor;

    void Start()
    {
        rend = GetComponent<Renderer>();
        originalColor = rend.material.color;
    }

    void Update()
    {
        // Rotate on all axes
        transform.Rotate(new Vector3(45, 45, 45) * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        rend.material.color = Color.green;
    }

    void OnCollisionExit(Collision collision)
    {
        rend.material.color = originalColor;
    }
}
