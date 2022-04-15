using System.Collections;
using UnityEngine;


[RequireComponent(typeof(SpriteRenderer))]
public class ObscuringItemFader : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void FadeOut()
    {
        StartCoroutine(FadeOutRoutine());
    }

    private IEnumerator FadeOutRoutine()
    {
        float currentAlpha = spriteRenderer.color.a;
        float distance = currentAlpha - Settings.targetAlpha;
        while (currentAlpha - Settings.targetAlpha > 0.01f)
        {
            currentAlpha -= distance / Settings.fadeOutSeconds * Time.deltaTime;
            spriteRenderer.color = new Color(1.0f, 1.0f, 1.0f, currentAlpha);
            yield return null;
        }

        spriteRenderer.color = new Color(1.0f, 1.0f, 1.0f, Settings.targetAlpha);
    }
    
    public void FadeIn()
    {
        StartCoroutine(FadeInRoutine());
    }

    private IEnumerator FadeInRoutine()
    {
        float currentAlpha = spriteRenderer.color.a;
        float distance = 1.0f - currentAlpha;

        while(1.0f - currentAlpha > 0.01f)
        {
            currentAlpha += distance / Settings.fadeInSeconds * Time.deltaTime;
            spriteRenderer.color = new Color(1.0f, 1.0f, 1.0f, currentAlpha);
            yield return null;
        }

        spriteRenderer.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
    }
}
