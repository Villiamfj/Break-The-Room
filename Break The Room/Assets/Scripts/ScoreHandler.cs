using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreHandler : MonoBehaviour
{
    public static float score = 0;


    GameObject TScoreText;
    GameObject TscoreBoard;
    GameObject TscoreBoard2;

    public GameObject Teleport1;
    public float score4Tele2 = 9;
    public GameObject Teleport2;
    public float score4tele3 = 20;
    public GameObject Teleport3;
    public float score4tele4 = 40;
    public GameObject Teleport4;


    // Start is called before the first frame update
    void Start()
    {
        TScoreText = GameObject.Find("ScoreTotalText");
        TscoreBoard = GameObject.Find("Points tal");
        TscoreBoard2 = GameObject.Find("Points tal2");
        Teleport2.SetActive(false);
        Teleport3.SetActive(false);
        Teleport4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        TScoreText.GetComponent<TextMesh>().text = score.ToString();
        TscoreBoard.GetComponent<TextMesh>().text = score.ToString();
        TscoreBoard2.GetComponent<TextMesh>().text = score.ToString();


        if (score > score4Tele2)
        {
            //Debug.Log("2 unlocked");
            Teleport1.SetActive(false);
            Teleport2.SetActive(true);
        }
        else if (score > score4tele3)
        {
            //Debug.Log("3 unlocked");
            //Teleport2.SetActive(false);
            //Teleport3.SetActive(true);
        }
        else if (score > score4tele4)
        {
            //Debug.Log("4 unlocked");
            //Teleport3.SetActive(false);
            //Teleport4.SetActive(true);
        }
        
    }
}
