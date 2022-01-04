using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    int correctAnswers = 0;
    int questionsSeen = 0;

    // Getter method
    public int GetCorrectAnswers()
    {
        return correctAnswers;
    }

    // Setter method
    public void IncrementCorrectAnswers()
    {
        correctAnswers++;
    }
    
    // Getter method
    public int GetQuestionsSeen()
    {
        return questionsSeen;
    }

    // Setter method
    public void IncrementQuestionsSeen()
    {
        questionsSeen++;
    }

    public int CalculateScore()
    {
        return Mathf.RoundToInt(correctAnswers / (float)questionsSeen * 100);
    }
}
