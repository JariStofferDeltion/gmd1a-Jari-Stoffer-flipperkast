using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour {

 public void RetryOne () {

   SceneManager.LoadScene("PinballPlayingfield"); //laad de Pinballplayingfield scene nadat je op retry geklikt hebt//
     }
}
