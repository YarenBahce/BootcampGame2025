using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    private bool isDead = false;

    public void Die()
    {
        if (isDead) return;

        isDead = true;
        Debug.Log("Oyuncu öldü!");

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }
}
