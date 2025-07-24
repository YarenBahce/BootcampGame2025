using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishZone : MonoBehaviour
{
    private bool hasFinished = false;

    private void OnTriggerEnter(Collider other)
    {
        if (hasFinished) return;

        if (other.CompareTag("Player"))
        {
            hasFinished = true;
            Debug.Log("Oyunu Kazandın!");

            Time.timeScale = 0f;
        }
    }
}
