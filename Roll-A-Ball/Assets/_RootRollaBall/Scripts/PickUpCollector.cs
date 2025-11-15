using UnityEngine;

public class Pickup : MonoBehaviour
{
    public static int totalPickups = 10;       // Cantidad total de pickups en la escena
    public static int collectedPickups = 10;   // Cantidad recogida

    private void Start()
    {
        totalPickups++;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            collectedPickups++;
            Destroy(gameObject);
        }
    }
}

