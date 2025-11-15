using TMPro;
using Unity.Cinemachine;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInteractor : MonoBehaviour
{
    [Header("Points System")]
    public int points; //Puntuación actual del player (en juego)
    public int winPoints = 1; //Puntuación a alcanzar para revelar el pic
    public TMP_Text pointsText; //Ref al texto de puntos para que cambie dinámicamente
    public GameObject winPickUp;
    private int SceneToLoad = 6;

    [Header("Sound References")]
    public PlayerController playerCont; //Ref als cript que contiene las llamadas a sonidos

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        points = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (points >= winPoints)
        {
            winPickUp.SetActive(true);
        }

        pointsText.text = "Points: " + points.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            points += 1;
            //Destroy(other.gameObject);
            other.gameObject.SetActive(false);
            playerCont.PlaySFX(1);
        }
        if (other.gameObject.CompareTag("Obstacle"))
        {
            SceneManager.LoadScene(SceneToLoad);
            playerCont.PlaySFX(0);
        }
    }

    
}


