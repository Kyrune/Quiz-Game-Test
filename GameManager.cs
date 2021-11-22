using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    Quiz quiz;

    void Awake() 
    {
        quiz = FindObjectOfType<Quiz>();
    }

    void Start()
    {
        quiz.gameObject.SetActive(true);
    }

    void Update()
    {
        
    }
}
