using UnityEngine;

public class GenericsGame : MonoBehaviour
{
    void Start()
    {
        if (TryGetComponent<AudioSource>(out var audio))
        {
            Debug.Log("Found AudioSource");
        }
        else
        {
            Debug.Log("No AudioSource attached.");
        }
    }

}
