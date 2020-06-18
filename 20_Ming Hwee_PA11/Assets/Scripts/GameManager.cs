using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager thisManager;

    public Text Score;

    public float ScoreNum;
    // Start is called before the first frame update
    void Start()
    {
        thisManager = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore()
    {
        ScoreNum++;
        Score.text = "Score : " + ScoreNum;
    }
}
