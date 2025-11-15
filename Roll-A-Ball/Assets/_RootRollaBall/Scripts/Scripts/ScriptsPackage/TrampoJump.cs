using UnityEngine;

public class TrampoJump : MonoBehaviour
{
    public float fuerzaTrampolín = 500f;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Rigidbody rb = other.rigidbody;
            if (rb != null)
            {
                rb.AddForce(Vector3.up * fuerzaTrampolín , ForceMode.Impulse);
            }
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
