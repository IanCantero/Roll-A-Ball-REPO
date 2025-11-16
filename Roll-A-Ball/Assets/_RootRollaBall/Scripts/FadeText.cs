
using UnityEngine;

public class FadeInOutMessage : MonoBehaviour
{
    public CanvasGroup canvasGroup;
    public float fadeDuration = 2f;   
    public float displayDuration = 3f; 

    private void Start()
    {
        StartCoroutine(ShowMessage());
    }

    private System.Collections.IEnumerator ShowMessage()
    {
        
        yield return FadeCanvas(0, 1, fadeDuration);

        
        yield return new WaitForSeconds(displayDuration);

       
        yield return FadeCanvas(1, 0, fadeDuration);
    }

    private System.Collections.IEnumerator FadeCanvas(float from, float to, float duration)
    {
        float elapsedTime = 0f;
        while (elapsedTime < duration)
        {
            canvasGroup.alpha = Mathf.Lerp(from, to, elapsedTime / duration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        canvasGroup.alpha = to;
    }
}
