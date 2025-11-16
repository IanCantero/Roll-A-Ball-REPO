using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject doorClosed;
    public GameObject doorAnimated;
    public AudioClip doorClip;
    private AudioSource audioSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.playOnAwake = false;
        audioSource.clip = doorClip; 
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            doorAnimated.SetActive(true);
            Destroy(doorClosed);

            audioSource.Play();

            Debug.Log("Door opened!");
        }
    }
}
