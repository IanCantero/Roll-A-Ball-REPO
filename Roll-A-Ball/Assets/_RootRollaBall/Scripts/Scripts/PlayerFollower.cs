using UnityEngine;

public class PlayerFollower : MonoBehaviour
{
    public Transform player;
    public float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null) return;
        float distance = Vector3.Distance(transform.position, player.position);
     

        Vector3 direction = (player.position - transform.position).normalized;
        transform.position += direction * speed * Time.deltaTime;

        transform.LookAt(player.position);
    }
}
