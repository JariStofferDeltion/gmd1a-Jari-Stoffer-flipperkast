using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {
    public Vector3 spawnpoint = new Vector3(-2.91f, -0.6f, 0.17f); //Zet bal terug op spawnpoint nadat hij gameover is gegaan
    public GameObject pinball;
    
    public void OnTriggerEnter(Collider Respawn)
    {
        pinball.transform.position = spawnpoint;
        SceneManager.LoadScene("GameOver"); //Laad de Gameover scene nadat je gameover bent gegaan
    }



	
}
