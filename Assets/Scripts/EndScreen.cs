using UnityEngine;
using TMPro;



public class EndScreen : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI finalScoreText;
    ScoreKeeper scoreKeeper;

    void Awake()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }

    public void showFinalScore()
    {
        finalScoreText.text = "Congratulations!\nYour final score is: " + scoreKeeper.CalculateScore() + "%"; 
    }
}
