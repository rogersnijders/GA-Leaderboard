using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI[] playerNamesTMP;  // TextMeshPro elements to display player names
    public TextMeshProUGUI[] playerScoresTMP; // TextMeshPro elements to display player scores
    public Slider[] scoreBars;               // Slider elements to visualize scores as bars

    private int[] scores;                   // Array to store player scores (3 players)

    private void Start()
    {
        // Initialize scores to zero
        scores = new int[3];
        UpdateUI();
    }

    public void UpdateScore(int playerIndex, int scoreChange)
    {
        scores[playerIndex] += scoreChange;
        UpdateUI();
    }

    private void UpdateUI()
    {
        for (int i = 0; i < playerNamesTMP.Length; i++)
        {
            playerScoresTMP[i].text = scores[i].ToString();
            scoreBars[i].value = scores[i];
        }
    }
}
