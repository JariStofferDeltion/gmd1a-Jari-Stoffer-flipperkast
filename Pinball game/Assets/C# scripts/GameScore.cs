using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameScore : MonoBehaviour
{

    public void OnCollisionEnter(Collision collision)
    {
        if (gameObject.tag == "Bumper") 
        {
            GameScore2.scoreGainUp += 10; //Elke keer als de bal de bumper aanraakt word er 10 punten bij je score opgeteld//
        }
    }
}
