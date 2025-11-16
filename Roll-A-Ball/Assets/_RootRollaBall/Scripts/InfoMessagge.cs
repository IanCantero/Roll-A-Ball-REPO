using UnityEngine;

public class InfoMessagge : MonoBehaviour
{
    public GameObject messageUI;
    public float duration = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        messageUI.SetActive(true);
        Invoke("HideMessage", duration);
    }

    void HideMessage()
    {
        messageUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
