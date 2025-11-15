using UnityEngine;

public class OpenWindow : MonoBehaviour
{
    public GameObject windowDestroyed;
    public GameObject windowShowed;
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
            windowShowed.SetActive(true);
            Destroy(windowDestroyed);
            Debug.Log("Window opened!");
        }
    }
}
