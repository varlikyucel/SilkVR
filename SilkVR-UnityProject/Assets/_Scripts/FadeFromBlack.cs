using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadeFromBlack : MonoBehaviour
{
    public Image fadeOverlay; // Assign the full-screen black Image in the inspector
    public float fadeDuration = 2.0f; // Duration of the fade effect

    void Start()
    {
        StartCoroutine(FadeIn());
    }

    IEnumerator FadeIn()
    {
        float currentTime = 0f;
        Color startColor = fadeOverlay.color;
        while (currentTime < fadeDuration)
        {
            float alpha = Mathf.Lerp(1f, 0f, currentTime / fadeDuration);
            fadeOverlay.color = new Color(startColor.r, startColor.g, startColor.b, alpha);
            currentTime += Time.deltaTime;
            yield return null;
        }
        fadeOverlay.gameObject.SetActive(false); // Optionally disable the overlay after fading
    }
}
