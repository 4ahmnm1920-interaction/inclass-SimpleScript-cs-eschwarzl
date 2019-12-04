using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SetScore(9, "Ice");
    }

    // Update is called once per frame
    void Update()
    {
        SetScore(5, "Pete");
    }

    public void SetScore(int score, string name)
    {
        int scoreValue = score;
        string nameValue = name;
        Debug.Log("score=" + scoreValue + " name=" + nameValue);
    }
}
