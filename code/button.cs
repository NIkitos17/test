using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class button : MonoBehaviour
{
    public GameObject tip;
    public Sprite sptite_1, sptite_2;
    public string action;
    public void Close ()
    {
        tip.SetActive(false);
    }
    void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().sprite = sptite_2;
    }
    void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().sprite = sptite_1;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.LoadLevel("menu");
        }
    }
    public void Option()
    {
        Application.LoadLevel("options");
    }
    public void Exit()
    {
        Application.Quit();
    }
    void OnMouseUpAsButton()
    {
        switch (gameObject.name)
        {
            case "next":
                Click.button = 0;
                Application.LoadLevel("game");
                break;
            case "exit to menu":
                Application.LoadLevel("menu");
                break;


            case "Health":
                Application.LoadLevel("Hp");
                break;
            case "Needs":
                Application.LoadLevel("Needs");
                break;
            case "Job":
                Application.LoadLevel("Job");
                break;
            case "legitimate":
                Application.LoadLevel("Job_legitimate");
                break;
            case "criminal":
                Application.LoadLevel("Job_criminal");
                break;

            case "Upgrades":
                Application.LoadLevel("Upgrades");
                break;



            case "foot":
                Application.LoadLevel("Needs_food");
                break;
            case "energy":
                Application.LoadLevel("Needs_energy");
                break;


        }
        if (Click.proverka_time == 0)
        {
            switch (gameObject.name)
            {
                case "back job":
                    Application.LoadLevel("Job");
                    break;
                case "back needs":
                    Application.LoadLevel("Needs");
                    break;
                case "bask game":
                    Application.LoadLevel("game");
                    break;
            }
        }
        if (Click.transport < 4)
        {
            switch (gameObject.name)
            {
                case "Trensport":
                    Application.LoadLevel("Transport");
                    break;
            }
        }
        if (Click.education < 8)
        {
            switch (gameObject.name)
            {
                case "Education":
                    Application.LoadLevel("Education");
                    break;
            }
        }
        if (Click.need < 11 && Click.need1 < 3)
        {
            switch (gameObject.name)
            {
                case "goods":
                    Application.LoadLevel("Needs_goods");
                    break;
            }
        }
        if (Click.hous < 8)
        {
            switch (gameObject.name)
            {
                case "House":
                    Application.LoadLevel("House");
                    break;
            }
        }

    }
}
