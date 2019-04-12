using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreHandler : MonoBehaviour
{
    public static float score = 0;


    GameObject TScoreText;
    GameObject TscoreBoard;


    // Start is called before the first frame update
    void Start()
    {
        TScoreText = GameObject.Find("ScoreTotalText");
        TscoreBoard = GameObject.Find("Points tal");

    }

    // Update is called once per frame
    void Update()
    {
        TScoreText.GetComponent<TextMesh>().text = score.ToString();
        TscoreBoard.GetComponent<TextMesh>().text = score.ToString();
    }
}
