using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TriggerChangeScene : MonoBehaviour
{

    public int sceneToLoad;

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
        if (other.gameObject.CompareTag("Exc.PickUp"))
        {
            LoadScene(sceneToLoad);
        }
    }

    public void LoadScene(int sceneToLoad)
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
