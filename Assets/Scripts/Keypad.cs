using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Keypad : MonoBehaviour
{
    public GameObject player;
    public GameObject keypadOB;

    public GameObject preasure;


    public AudioSource button;
    public AudioSource correct;
    public AudioSource wrong;


    public TextMeshProUGUI textOB;
    public string answer = "12345";

    




    void Start()
    {
        keypadOB.SetActive(false);

        
    }


    public void Number(int number)
    {
        textOB.text += number.ToString();
        button.Play();
    }

    public void Execute()
    {
        if (textOB.text == answer)
        {
            correct.Play();
            textOB.text = "Nice work";

        }
        else
        {
            wrong.Play();
            textOB.text = "Sike!!!";
        }


    }

    public void Clear()
    {
        {
            textOB.text = "";
            button.Play();
        }
    }

    public void Exit()
    {
        keypadOB.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        player.GetComponent<InputManager>().enabled = true;
    }

    public void Update()
    {
        if (textOB.text == "Nice work")
        {
            preasure.SetActive(true);
            Debug.Log("its open");
        }


        if (keypadOB.activeInHierarchy)
        {
           
          
            player.GetComponent<InputManager>().enabled = false;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }

    }


}