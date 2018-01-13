using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Click.proverka_time == 0)
        {
            Camera.main.GetComponent<Click>().Savve();
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                Application.LoadLevel("Hp");
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                Application.LoadLevel("Needs");
            }

            if (Application.loadedLevelName == "Needs")
            {
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    if (Click.need < 11 && Click.need1 < 3)
                    {
                        Application.LoadLevel("Needs_goods");
                    }
                }
                if (Input.GetKeyDown(KeyCode.W))
                {
                    Application.LoadLevel("Needs_food");
                }
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Application.LoadLevel("Needs_energy");
                }
            }

            if (Input.GetKeyDown(KeyCode.Tab))
            {
                Application.LoadLevel("game");
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                Application.LoadLevel("Job");
            }
            if (Application.loadedLevelName == "Job")
            {
                if (Input.GetKeyDown(KeyCode.A))
                {
                    Application.LoadLevel("Job_legitimate");
                }
                if (Input.GetKeyDown(KeyCode.S))
                {
                    Application.LoadLevel("Job_criminal");
                }
            }
            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                if (Click.education < 8)
                {
                    Application.LoadLevel("Education");
                }
            }

            if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                if (Click.transport < 4)
                {
                    Application.LoadLevel("Transport");
                }


            }
            if (Input.GetKeyDown(KeyCode.Alpha6))
            {
                if (Click.hous < 8)
                {
                    Application.LoadLevel("House");
                }
            }
        }
    }
}
