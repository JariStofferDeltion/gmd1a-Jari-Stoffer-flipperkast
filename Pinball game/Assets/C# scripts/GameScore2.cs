using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameScore2 : MonoBehaviour
{

    public Text scoreText;
    public static int scoreGainUp;

    void Update()
    {
        scoreText.text = "Points:" + scoreGainUp; //de score word verhoogt bij de text Points:
    }
}