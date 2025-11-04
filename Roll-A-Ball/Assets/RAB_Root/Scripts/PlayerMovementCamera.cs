using UnityEngine;

public class PlayerMovementCamera : MonoBehaviour
{
    public float Velocidad = 5f;
    public Transform camara;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
    }
}
