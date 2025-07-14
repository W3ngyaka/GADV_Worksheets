using UnityEngine;

public class Player1 : MonoBehaviour
{
    void Start()
    {
        CheckLineOfSight(); // or put this in Update() for real-time
    }

    void CheckLineOfSight()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        RaycastHit hitData;

        foreach (GameObject enemy in enemies)
        {
            Vector3 vec = enemy.transform.position - transform.position;

            Debug.DrawRay(transform.position, vec, Color.red, 1f);

            if (Physics.Raycast(transform.position, vec, out hitData, 30f))
            {
                if (hitData.collider.gameObject == enemy)
                {
                    enemy.GetComponent<Renderer>().material.color = Color.green;
                }
                else
                {
                    enemy.GetComponent<Renderer>().material.color = Color.red;
                }
            }
        }
    }
}
