using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transport : MonoBehaviour
{

    public void Bike()
    {
        Main.Bike();
    }
    public void To_buy_a_car()
    {
        Main.To_buy_a_car();
    }
    public void Buy_a_van()
    {
        Main.Buy_a_van();
    }
    public void To_buy_a_supercar()
    {
        Camera.main.gameObject.GetComponent<Main>().To_buy_a_supercar();
    }
}
