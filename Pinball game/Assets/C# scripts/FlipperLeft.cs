using UnityEngine;
using System.Collections;


public class FlipperLeft : MonoBehaviour
{
    public float maxAngle = -20.0f; //maximale hoek die word gemaakt door de flipper//
    public float flipTime = 0.1f; //snelheid waarme de flipper word gedraait, hoe lager waarde hoe sneller de flipper draait//
    public string buttonName = "Horizontal"; //(aswd)buttons voor het activere van het draaien van de flippers//
    public bool bol; //zortg er voor dat de flipper collision geactiveerd word//
    private Quaternion initialOrientation; //het begin punt voordat de hoek gemaakt word//
    private Quaternion finalOrientation; //de hoek die hier gemaakt word//
    private float t; //rotatie op stilstaand moment van (draaiende) object//
    public Vector3 direction; //direction voor collision//
    public Rigidbody ball; //GameObject > bal//
    public float force = -0.02f; //snelheid waarmee de bal weg word geschoten//

    // Use this for initialization
    void Start()
    {
        initialOrientation = transform.rotation; //begin waarden van (rotatie) object = begin initialOrientation//
        finalOrientation.eulerAngles = new Vector3(initialOrientation.eulerAngles.x, initialOrientation.eulerAngles.y + maxAngle, initialOrientation.eulerAngles.z); //eindwaarde van object na (beginwaarde rotatie x-as, beginwaarde rotatie y-as + maximale draaihoek[in dit geval nodig op y-as voor de juiste hoek kan verschillen bij andere projecten], beginwaarde rotatie z-as)
    }                                                                                                                                                             // Update is called once per frame
    void Update()
    {
        if (Input.GetButton(buttonName))//buttonName1 = de knop die je indrukt//
        {
            bol = true;
            transform.rotation = Quaternion.Slerp(initialOrientation, finalOrientation, t / flipTime);//verandering in rotatie object door middel van begin rotatie , eindrotatie, stilstaand punt en snelheid//
            t += Time.deltaTime; //stilstaand punt + snelheid van berekenen frames per second//
            if (t > flipTime) //als stilstaand punt groter is dan snelheid//
            {
                t = flipTime;//het stilstaand punt word veranderd naar het eind punt//
            }
        }
        else
        {
            bol = false;

            transform.rotation = Quaternion.Slerp(initialOrientation, finalOrientation, t / flipTime);
            t -= Time.deltaTime;
            if (t < 0)//als het stilstaand punt kleiner is dan 0//
            {
                t = 0;//het stilstaand punt is weer bij het begin//
            }
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (bol == true)
        {
          
            direction = collision.contacts[0].point; //veroorzaakt een terugkaatsende richting tijdens de collision//
            ball.AddForce(direction * force); //dit is de snelheid waarme de bal terug gekaatst word//
        }
    }
}
