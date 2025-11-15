using UnityEngine;
using TMPro;   

public class ShowMessageWhenAllCollected : MonoBehaviour
{
    public TextMeshProUGUI messageTMP;
    private bool messageShown = false;

    void Start()
    {
        if (messageTMP != null)
            messageTMP.gameObject.SetActive(false);
    }

    void Update()
    {
        if (!messageShown && Pickup.collectedPickups == Pickup.totalPickups)
        {
            messageShown = true;

            if (messageTMP != null)
                messageTMP.gameObject.SetActive(true);

            messageTMP.text = "Escape through the window!";
        }
    }
}
