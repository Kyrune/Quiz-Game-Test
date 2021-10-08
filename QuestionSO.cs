using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Quiz Question", fileName = "New Question")]
public class QuestionSO : ScriptableObject
{
    [SerializeField] string question = "Enter new question text here";

    public string GetQuestion()
    {
        return question;
    }
}
