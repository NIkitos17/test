using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class house : MonoBehaviour {


    public void Box()
    {
        Main.Box();
    }
    public void Basement()
    {
        Main.Basement();
    }
    public void Attic()
    {
        Main.Attic();
    }
    public void Room()
    {
        Main.Room();
    }
    public void Apartment()
    {
        Main.Apartment();
    }
    public void Buy_apartment()
    {
        Main.Buy_apartment();
    }
    public void Office()
    {
        Main.Office();
    }
    public void House()
    {
        Camera.main.GetComponent<Main>().House();
    }
    /*many*/
    public void Room_many()
    {
        Main.Room_many();
    }
    public void Apartment_many()
    {
        Main.Apartment_many();
    }

    // Update is called once per frame
    void Update () {
       
    }
}
