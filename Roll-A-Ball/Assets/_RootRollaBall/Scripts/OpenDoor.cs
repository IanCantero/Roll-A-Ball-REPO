using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject doorClosed;
    public GameObject doorAnimated;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            doorAnimated.SetActive(true);
            Destroy(doorClosed);
            Debug.Log("Door opened!");
        }
    }
}
