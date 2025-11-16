using UnityEngine;

public class ActivateHands : MonoBehaviour
{
    public GameObject objectToActive;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            objectToActive.SetActive(true);
        }
    }
}
