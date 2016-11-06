using UnityEngine;
using System.Collections;

public class Bumper : MonoBehaviour {

        public Vector3 direction; //waar de bal naartoe geschoten word als de bal de bumper raakt//
        public Rigidbody ball; //rigidbody > ball//
        public float force; // kracht waarmee de ball af geschoten word als hij de bumper raakt//

        public void OnCollisionEnter(Collision collision) //hier word op geroepen wat er gebeurd als collisions elkaar raken (collision collision)//
        {
        direction = collision.contacts[0].point; //welke kant hij op geschoten word als hij op 0 staat//
        ball.AddForce(direction * force); // de force word toegevoegd aan de direction//
        }
    }
