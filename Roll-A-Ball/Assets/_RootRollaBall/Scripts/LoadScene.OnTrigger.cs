using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Verifica que sea el jugador (con tag "Player")
        if (other.CompareTag("Player"))
        {
            // Cargar la escena número 5
            SceneManager.LoadScene(5);
        }
    }
}