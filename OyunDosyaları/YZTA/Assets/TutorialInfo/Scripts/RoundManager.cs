using UnityEngine;
using TMPro; // UI için

public class RoundManager : MonoBehaviour
{
    public enum GameState { Lobby, Playing, RoundEnd }
    public GameState currentState;

    public float roundDuration = 60f; // 60 saniye round
    private float timer;

    public TMP_Text stateText;
    public TMP_Text timerText;

    void Start()
    {
        EnterLobby();
    }

    void Update()
    {
        switch (currentState)
        {
            case GameState.Lobby:
                // Şimdilik otomatik başlat
                if (Input.GetKeyDown(KeyCode.Space))
                    StartRound();
                break;
            case GameState.Playing:
                timer -= Time.deltaTime;
                timerText.text = "Time: " + Mathf.Ceil(timer).ToString();

                if (timer <= 0)
                    EndRound();
                break;
            case GameState.RoundEnd:
                // Space ile yeni round
                if (Input.GetKeyDown(KeyCode.Space))
                    StartRound();
                break;
        }
    }

    void EnterLobby()
    {
        currentState = GameState.Lobby;
        stateText.text = "LOBBY - Press Space to Start";
        timerText.text = "";
    }

    void StartRound()
    {
        currentState = GameState.Playing;
        timer = roundDuration;
        stateText.text = "ROUND STARTED!";
    }

    void EndRound()
    {
        currentState = GameState.RoundEnd;
        stateText.text = "ROUND ENDED! Press Space for next round";
        timerText.text = "";
    }
}
