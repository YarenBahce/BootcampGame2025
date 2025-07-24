using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public Rotator targetRotator;

    private Color originalColor;
    private Renderer rend;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        originalColor = rend.material.color;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            targetRotator?.StopRotation();
            rend.material.color = DarkenColor(originalColor, 0.5f);
            Debug.Log($"Çark DURDU: {targetRotator.name}");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            targetRotator?.StartRotation();
            rend.material.color = originalColor;
            Debug.Log($"Çark TEKRAR DÖNÜYOR: {targetRotator.name}");
        }
    }

    private Color DarkenColor(Color color, float amount)
    {
        return new Color(color.r * amount, color.g * amount, color.b * amount, color.a);
    }
}
