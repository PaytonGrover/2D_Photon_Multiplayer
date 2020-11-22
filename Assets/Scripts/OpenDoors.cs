using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenDoors : MonoBehaviour
{

    public GameObject ButtonOne;
    public GameObject DoorOne;

    public GameObject ButtonTwo;
    public GameObject DoorTwo;

    public GameObject ButtonThree;
    public GameObject DoorThree;

    public GameObject ButtonFour;
    public GameObject DoorFour;

    public GameObject ButtonFive;
    public GameObject DoorFive;

    public GameObject ButtonSix;
    public GameObject DoorSix;

    public GameObject ButtonSeven;
    public GameObject DoorSeven;

    public GameObject ButtonEight;
    public GameObject DoorEight;

    public GameObject ButtonNine;
    public GameObject DoorNine;

    public GameObject ButtonTen;
    public GameObject DoorTen;

    public GameObject ButtonEleven;
    public GameObject DoorEleven;

    public GameObject ButtonTwelve;
    public GameObject DoorTwelve;

    public GameObject Player1;
    public GameObject Player2;
    public GameObject Player3;
    public GameObject Player4;


    public GameObject Win;
    [SerializeField]
    private Text WinText;
    [SerializeField]
    private Text LoseText;
    // Start is called before the first frame update
    void Start()
    {
        WinText.enabled = false;
        LoseText.enabled = false;
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (gameObject.name == ButtonOne.name)
        {

            if (collision.gameObject.tag == "Player")
            {
                Debug.Log("Hit1");
                Destroy(DoorOne);
            }
        }
        if (gameObject.name == ButtonTwo.name)
        {

            if (collision.gameObject.tag == "Player")
            {
                Debug.Log("Hit2");
                Destroy(DoorTwo);
            }
        }

        if (gameObject.name == ButtonThree.name)
        {

            if (collision.gameObject.tag == "Player")
            {
                Debug.Log("Hit3");
                Destroy(DoorThree);
            }
        }

        if (gameObject.name == ButtonFour.name)
        {

            if (collision.gameObject.tag == "Player")
            {
                Debug.Log("Hit4");
                Destroy(DoorFour);
                Destroy(ButtonFour);
            }
        }

        if (gameObject.name == ButtonFive.name)
        {

            if (collision.gameObject.tag == "Player")
            {
                Debug.Log("Hit5");
                Destroy(DoorFive);
            }
        }

        if (gameObject.name == ButtonSix.name)
        {

            if (collision.gameObject.tag == "Player")
            {
                Debug.Log("Hit6");
                Destroy(DoorSix);
            }
        }

        if (gameObject.name == ButtonSeven.name)
        {

            if (collision.gameObject.tag == "Player")
            {
                Debug.Log("Hit7");
                Destroy(DoorSeven);
            }
        }

        if (gameObject.name == ButtonEight.name)
        {

            if (collision.gameObject.tag == "Player")
            {
                Debug.Log("Hit8");
                Destroy(DoorEight);
            }
        }

        if (gameObject.name == ButtonNine.name)
        {

            if (collision.gameObject.tag == "Player")
            {
                Debug.Log("Hit9");
                Destroy(DoorNine);
            }
        }

        if (gameObject.name == ButtonTen.name)
        {

            if (collision.gameObject.tag == "Player")
            {
                Debug.Log("Hit10");
                Destroy(DoorTen);
            }
        }

        if (gameObject.name == ButtonEleven.name)
        {

            if (collision.gameObject.tag == "Player")
            {
                Debug.Log("Hit11");
                Destroy(DoorEleven);
            }
        }

        if (gameObject.name == ButtonTwelve.name)
        {

            if (collision.gameObject.tag == "Player")
            {
                Debug.Log("Hit12");
                Destroy(DoorTwelve);
            }
        }

        if (gameObject.name == Player1.name)
        {

            if (collision.gameObject.tag == "Player")
            {
                Debug.Log("Won");
                WinText.enabled = true;

            }else
            {
                LoseText.enabled = true;
            }
        }
        if (gameObject.name == Player2.name)
        {

            if (collision.gameObject.tag == "Player")
            {
                Debug.Log("Won");
                WinText.enabled = true;

            }
            else
            {
                LoseText.enabled = true;
            }
        }
        if (gameObject.name == Player3.name)
        {

            if (collision.gameObject.tag == "Player")
            {
                Debug.Log("Won");
                WinText.enabled = true;

            }
            else
            {
                LoseText.enabled = true;
            }
        }
        if (gameObject.name == Player4.name)
        {

            if (collision.gameObject.tag == "Player")
            {
                Debug.Log("Won");
                WinText.enabled = true;

            }
            else
            {
                LoseText.enabled = true;
            }
        }



    }
}
    


    
   

 

 