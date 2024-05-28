using UnityEngine;
using UnityEngine.UI;

public class UpdateScoreButton : MonoBehaviour
{
    public ScoreManager scoreManager; // Reference to the ScoreManager script
    public int playerIndex;           // 0, 1, or 2 to indicate the player

    public void AddScore(int scoreChange)
    {
        scoreManager.UpdateScore(playerIndex, scoreChange);
        Debug.Log("klik");
    }
}