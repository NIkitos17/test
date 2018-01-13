using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Job_criminal : MonoBehaviour {

    public GameObject Notice1;
    public GameObject Notice2;
    public GameObject Notice3;
    public GameObject Notice4;
    public GameObject Notice5;
    public GameObject Notice6;

    public void Populairity_in_transition ()
    {
        Camera.main.GetComponent<Main>().Populairity_in_transition();

    }
    public void To_steal_the_radio()
    {
        Camera.main.GetComponent<Main>().To_steal_the_radio();
    }
    public void Pickpocketing()
    {
        Camera.main.GetComponent<Main>().Pickpocketing();
    }
    public void Steal_bikes()
    {
        Camera.main.GetComponent<Main>().Steal_bikes();
    }
    public void To_steal_a_car()
    {
        Camera.main.GetComponent<Main>().To_steal_a_car();
    }
    public void Rob_stall()
    {
        Camera.main.GetComponent<Main>().Rob_stall();
    }
    public void To_Rob_apartment()
    {
        Camera.main.GetComponent<Main>().To_Rob_apartment();
    }
    public void To_Rob_a_private_house()
    {
        Camera.main.GetComponent<Main>().To_Rob_a_private_house();
    }
    public void To_Rob_a_Bank()
    {
        Camera.main.GetComponent<Main>().To_Rob_a_Bank();
    }
    public void Back ()
    {
        Notice1.SetActive(false);
    }



        // Update is called once per frame
    void Update () {
        if (Click.proverka_time == 0)
        {
            Click.alarm = 0;
            Click.charges = 0;
            Click.proverka = 0;
        }
    }
}
