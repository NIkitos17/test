using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class job_legal : MonoBehaviour {

    public void Drams ()
    {
        Camera.main.GetComponent<Main>().Rummaged_in_dumps();
    }
    public void Bottle ()
    {
        Camera.main.GetComponent<Main>().Bottle();  
    }
    public void Wash_cars_at_the_traffic_lights()
    {
        Camera.main.GetComponent<Main>().Wash_cars_at_the_traffic_lights();
    }
    public void Sorting_mail()
    {
        Camera.main.GetComponent<Main>().Sorting_mail();
    }
    public void Taksovat()
    {
        Camera.main.GetComponent<Main>().Taksovat();
    }
    public void To_work_in_the_factory()
    {
        Camera.main.GetComponent<Main>().To_work_in_the_factory();
    }
    public void In_the_office()
    {
        Camera.main.GetComponent<Main>().In_the_office();
    }
    public void To_work_as_a_programmer()
    {
        Camera.main.GetComponent<Main>().To_work_as_a_programmer();
    }
    public void Possess_own_company()
    {
        Camera.main.GetComponent<Main>().Possess_own_company();
    }

    public void Update()
    {
        if (Click.proverka_time == 0)
        {
            Click.alarm = 0;
            Click.charges = 0;
            Click.proverka = 0;
        }
    }


}
