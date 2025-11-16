using UnityEngine;

public class OpenWindow : MonoBehaviour
{
    public GameObject windowDestroyed;
    public GameObject windowShowed;
    public AudioClip windowClip;
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
        audioSource.clip = windowClip; 
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            windowShowed.SetActive(true);
            Destroy(windowDestroyed);

            audioSource.Play();

            Debug.Log("Window opened!");
        }
    }
}
