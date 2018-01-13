using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{

    public GameObject Notice1;
    public GameObject Notice2;
    public GameObject Notice3;
    public GameObject Notice4;
    public GameObject Notice5;
    public GameObject Notice6;
    public GameObject Notice7;
    public GameObject Notice8;

    public static float timer;
    public static int proverka = 0;


    public void Rummaged_in_dumps()
    {
        if (Click.proverka_time == 0)
        {
            Click.click += 30;
            Click.Hp -= 19;
            Click.Ea -= 19;
            Click.En -= 19;
            Click.clock += 1;
            Click.day++;
            Click.proverka_time = 0;
        }
    }
    
    public void Bottle()
    {

        if (Click.proverka_time == 0)
        {

            Click.proverka_time++;
            Click.proverka++;
            if (Click.hous == 0)
            {
                Notice1.SetActive(!Notice1.activeSelf);
                proverka++;
            }


            if (Click.hous >= 1)
            {
                Click.proverka_time = 0;
                Click.alarm++;
                if (Click.alarm == 1)
                {
                    Click.charges = Click.alarm;
                }
            }
        }

        if (Click.charges == 1)
        {

            Click.click += 50;
            Click.Hp -= 14;
            Click.Ea -= 14;
            Click.En -= 14;
            Click.day++;
            Click.clock += 1;

        }
    }


    public void Wash_cars_at_the_traffic_lights()
    {

        if (Click.proverka_time == 0)
        {

            Click.count = 0;
            if ((Click.hous >= 2) && (Click.need1 >= 1) && (Click.education >= 1))
            {
                Click.count++;
                Click.proverka_time = 0;
                Click.alarm += 2;
                if (Click.alarm == 2)
                {
                    Click.charges = Click.alarm;
                }
            }

            if (Click.count == 0)
            {

                Click.proverka += 2;
                Click.proverka_time++;
                if ((Click.hous >= 0) && (Click.need1 >= 0) && (Click.education >= 0))
                {
                    Notice2.SetActive(!Notice2.activeSelf);

                }

                if (Click.hous >= 2)
                {
                    Destroy(GameObject.Find("basement"));
                }
                if (Click.need1 >= 1)
                {
                    Destroy(GameObject.Find("sneakers"));
                }
                if (Click.education >= 1)
                {
                    Destroy(GameObject.Find("3 class"));
                }
            }
        }


        if (Click.charges == 2)
        {
            Click.click += 100;
            Click.Hp -= 12;
            Click.Ea -= 12;
            Click.En -= 12;
            Click.day++;
            Click.clock += 3;

        }

    }
    public void Sorting_mail()
    {

        if (Click.proverka_time == 0)
        {
            Click.count = 1;
            if ((Click.hous >= 3) && (Click.transport >= 1) && (Click.education >= 2))
            {
                Click.alarm += 3;
                Click.count += 2;
                Click.proverka_time = 0;
                if (Click.alarm == 3)
                {
                    Click.charges = Click.alarm;
                }
            }

            if (Click.count == 1)
            {

                Click.proverka += 3;
                Click.proverka_time++;
                if ((Click.hous >= 0) && (Click.transport >= 0) && (Click.education >= 0))
                {
                    Notice3.SetActive(!Notice3.activeSelf);
                }

                if (Click.hous >= 3)
                {
                    Destroy(GameObject.Find("attic"));
                }
                if (Click.transport >= 1)
                {
                    Destroy(GameObject.Find("bike"));
                }
                if (Click.education >= 2)
                {
                    Destroy(GameObject.Find("9 class"));
                }
            }
        }

        if (Click.charges == 3)
        {
            Click.click += 150;
            Click.Hp -= 10;
            Click.Ea -= 10;
            Click.En -= 10;
            Click.day++;
            Click.clock += 4;

        }
    }
    public void Taksovat()
    {
        if (Click.proverka_time == 0)
        {

            Click.count = 2;
            if ((Click.hous >= 4) && (Click.transport >= 2) && (Click.education >= 3))
            {
                Click.alarm += 4;
                Click.count += 3;
                if (Click.alarm == 4)
                {
                    Click.charges = Click.alarm;
                }
            }

            if (Click.count == 2)
            {

                Click.proverka += 4;
                Click.proverka_time++;
                if ((Click.hous >= 0) && (Click.transport >= 0) && (Click.education >= 0))
                {
                    Notice4.SetActive(!Notice4.activeSelf);
                }
                if (Click.hous >= 4)
                {
                    Destroy(GameObject.Find("room"));
                }
                if (Click.transport >= 2)
                {
                    Destroy(GameObject.Find("car"));
                }
                if (Click.education >= 3)
                {
                    Destroy(GameObject.Find("driver's license"));
                }
            }
        }
        if (Click.charges == 4)
        {
            Click.click += 350;
            Click.Hp -= 9;
            Click.Ea -= 9;
            Click.En -= 9;
            Click.day++;
            Click.clock += 5;

        }
    }
    public void To_work_in_the_factory()
    {
        if (Click.proverka_time == 0)
        {

            Click.count = 3;
            if ((Click.hous >= 5) && (Click.education >= 4) && (Click.need1 >= 1))
            {
                Click.alarm += 4;
                Click.count += 3;
                if (Click.alarm == 4)
                {
                    Click.charges = Click.alarm;
                }
            }

            if (Click.count == 3)
            {

                Click.proverka += 5;
                Click.proverka_time++;
                if ((Click.hous >= 0) && (Click.need1 >= 0) && (Click.education >= 0))
                {
                    Notice5.SetActive(!Notice5.activeSelf);
                }
                if (Click.hous >= 5)
                {
                    Destroy(GameObject.Find("apartment"));
                }
                if (Click.need1 >= 2)
                {
                    Destroy(GameObject.Find("special costume"));
                }
                if (Click.education >= 4)
                {
                    Destroy(GameObject.Find("College"));
                }
            }
        }
        if (Click.charges == 4)
        {
            Click.click += 650;
            Click.Hp -= 7;
            Click.Ea -= 7;
            Click.En -= 7;
            Click.day++;
            Click.clock += 8;
        }
    }
    public void In_the_office()
    {
        if (Click.proverka_time == 0)
        {

            Click.count = 4;

            if ((Click.hous >= 6) && (Click.education >= 5))
            {
                Click.alarm += 4;
                Click.count += 4;
                if (Click.alarm == 4)
                {
                    Click.charges = Click.alarm;
                }
            }

            if (Click.count == 4)
            {

                Click.proverka += 6;
                Click.proverka_time++;
                if ((Click.hous >= 0) && (Click.education >= 0))
                {
                    Notice6.SetActive(!Notice6.activeSelf);
                }

                if (Click.hous >= 6)
                {
                    Destroy(GameObject.Find("buy an apartment"));
                }
                if (Click.education >= 5)
                {
                    Destroy(GameObject.Find("higher education"));
                }
            }
        }
        if (Click.charges == 4)
        {
            Click.click += 1500;
            Click.Hp -= 10;
            Click.Ea -= 10;
            Click.En -= 10;
            Click.day++;
            Click.clock += 8;
        }
    }
    public void To_work_as_a_programmer()
    {
        if (Click.proverka_time == 0)
        {

            Click.count = 5;
            if ((Click.education == 6 || Click.education == 7) && (Click.need1 >= 1))
            {
                Click.alarm += 4;
                Click.count += 6;
                if (Click.alarm == 4)
                {
                    Click.charges = Click.alarm;
                }
            }

            if (Click.count == 5)
            {

                Click.proverka += 7;
                Click.proverka_time++;
                if ((Click.need1 >= 0) && (Click.education >= 0))
                {
                    Notice7.SetActive(!Notice7.activeSelf);
                }
                if (Click.need1 == 3)
                {
                    Destroy(GameObject.Find("computer"));
                }
                if (Click.education >= 6)
                {
                    Destroy(GameObject.Find("special courses"));
                }
                if (Click.education >= 7)
                {
                    Destroy(GameObject.Find("Deputy study granizei"));
                }
            }
        }
        if (Click.charges == 4)
        {
            Click.click += 5000;
            Click.Hp -= 30;
            Click.Ea -= 30;
            Click.En -= 30;
            Click.day++;
            Click.clock += 6;
        }

    }
    public void Possess_own_company()
    {
        if (Click.proverka_time == 0)
        {

            Click.count = 6;
            if ((Click.hous >= 7) && (Click.education >= 8))
            {
                Click.alarm += 4;
                Click.count += 7;
                if (Click.alarm == 4)
                {
                    Click.charges = Click.alarm;
                }
            }

            if (Click.count == 6)
            {

                Click.proverka += 8;
                Click.proverka_time++;
                if ((Click.hous >= 0) && (Click.education >= 0))
                {
                    Notice8.SetActive(!Notice8.activeSelf);
                }

                if (Click.hous >= 7)
                {
                    Destroy(GameObject.Find("office"));
                }
                if (Click.hous >= 8)
                {
                    Destroy(GameObject.Find("personal house"));
                }
                if (Click.education >= 8)
                {
                    Destroy(GameObject.Find("boilers of Economics courses"));
                }

            }
        }
        if (Click.charges == 4)
        {
            Click.click += 10000;
            Click.Hp -= 40;
            Click.Ea -= 40;
            Click.En -= 40;
            Click.day++;
            Click.clock += 3;
        }
    }




    public void Populairity_in_transition()
    {
        if (Click.proverka_time == 0)
        {
            Click.points = UnityEngine.Random.Range(0, 30);
            Click.click += Click.points;
            Click.Hp -= 19;
            Click.Ea -= 19;
            Click.En -= 19;
            Click.day++;
            Click.proverka_time = 0;
            Click.clock += 3;
        }
    }
    public void To_steal_the_radio()
    {
        if (Click.proverka_time == 0)
        {
            Click.points = UnityEngine.Random.Range(0, 70);
            Click.click += Click.points;
            Click.fine = UnityEngine.Random.Range(0, 3);
            if (Click.fine == 3)
            {
                Click.click -= 3;
            }
            Click.Hp -= 17;
            Click.Ea -= 17;
            Click.En -= 17;
            Click.day++;
            Click.proverka_time = 0;
            Click.clock += 1;
        }
    }
    public void Pickpocketing()
    {
        if (Click.proverka_time == 0)
        {
            Click.points = UnityEngine.Random.Range(50, 150);
            Click.click += Click.points;
            Click.fine = UnityEngine.Random.Range(0, 3);
            if (Click.fine == 3)
            {
                Click.click -= 190;
            }
            Click.Hp -= 15;
            Click.Ea -= 15;
            Click.En -= 15;
            Click.day++;
            Click.proverka_time = 0;
            Click.clock += 1;
        }
    }
    public void Steal_bikes()
    {
        if (Click.proverka_time == 0)
        {
            Click.count = 7;
            if ((Click.need >= 1))
            {
                Click.alarm += 4;
                Click.count += 8;
                if (Click.alarm == 4)
                {
                    Click.charges = Click.alarm;
                }
            }

            if (Click.count == 7)
            {
                Click.proverka += 9;
                Click.proverka_time++;
                if ((Click.need == 0))
                {
                    Notice1.SetActive(true);
                }
                if (Click.need >= 1)
                {
                    Destroy(GameObject.Find("clippers"));
                }
            }
        }
        if (Click.charges == 4)
        {
            Click.click += 250;
            Click.fine = UnityEngine.Random.Range(0, 3);
            if (Click.fine == 3)
            {
                Click.click -= 290;
            }
            Click.Hp -= 13;
            Click.Ea -= 13;
            Click.En -= 13;
            Click.day++;
            Click.clock += 1;
        }
    }
    public void To_steal_a_car()
    {
        if (Click.proverka_time == 0)
        {
            Click.count = 8;
            if ((Click.need >= 2))
            {
                Click.alarm += 6;
                Click.count += 9;
                if (Click.alarm == 6)
                {
                    Click.charges = Click.alarm;
                }
            }

            if (Click.count == 8)
            {
                Click.proverka += 10;
                Click.proverka_time++;
                if ((Click.need >= 0))
                {
                    Notice2.SetActive(!Notice2.activeSelf);
                }

                if (Click.need >= 2)
                {

                    Destroy(GameObject.Find("stocking on his head"));
                }

            }

        }
        if (Click.charges == 6)
        {
            Click.points = UnityEngine.Random.Range(0, 350);
            Click.click += Click.points;
            Click.fine = UnityEngine.Random.Range(0, 3);
            if (Click.fine == 3)
            {
                Click.click -= 370;
            }
            Click.Hp -= 11;
            Click.Ea -= 11;
            Click.En -= 11;
            Click.day++;
            Click.clock += 3;
        }
    }
    public void Rob_stall()
    {
        if (Click.proverka_time == 0)
        {
            Click.alarm = 0;
            Click.count = 9;
            if ((Click.need >= 4))
            {
                Click.alarm += 4;
                Click.count += 10;
                if (Click.alarm == 4)
                {
                    Click.charges = Click.alarm;
                }
            }

            if (Click.count == 9)
            {
                Click.proverka += 11;
                Click.proverka_time++;
                if ((Click.need >= 0))
                {
                    Notice3.SetActive(!Notice3.activeSelf);
                }

                if (Click.need >= 3)
                {
                    Destroy(GameObject.Find("1 naparnik"));
                }
                if (Click.need >= 4)
                {
                    Destroy(GameObject.Find("master key"));
                }


            }
        }
        if (Click.charges == 4)
        {
            Click.points = UnityEngine.Random.Range(0, 450);
            Click.click += Click.points;
            Click.fine = UnityEngine.Random.Range(0, 3);
            if (Click.fine == 3)
            {
                Click.click -= 500;
            }
            Click.Hp -= 9;
            Click.Ea -= 9;
            Click.En -= 9;
            Click.day++;
            Click.clock += 4;
        }
    }
    public void To_Rob_apartment()
    {
        if (Click.proverka_time == 0)
        {
            Click.count = 10;
            if ((Click.need >= 6))
            {
                Click.alarm += 4;
                Click.count += 11;
                if (Click.alarm == 4)
                {
                    Click.charges = Click.alarm;
                }
            }

            if (Click.count == 10)
            {
                Click.proverka += 12;
                Click.proverka_time++;
                if ((Click.need >= 0))
                {
                    Notice4.SetActive(!Notice4.activeSelf);
                }

                if (Click.need >= 5)
                {
                    Destroy(GameObject.Find("bolgarka"));
                }
                if (Click.need >= 6)
                {
                    Destroy(GameObject.Find("masks"));
                }


            }
        }
        if (Click.charges == 4)
        {
            Click.points = UnityEngine.Random.Range(90, 950);
            Click.click += Click.points;
            Click.fine = UnityEngine.Random.Range(0, 3);
            if (Click.fine == 3)
            {
                Click.click -= 100;
            }
            Click.Hp -= 7;
            Click.Ea -= 7;
            Click.En -= 7;
            Click.day++;
            Click.clock += 2;
        }
    }
    public void To_Rob_a_private_house()
    {
        if (Click.proverka_time == 0)
        {
            Click.count = 11;
            if ((Click.need >= 8))
            {
                Click.alarm += 4;
                Click.count += 12;
                if (Click.alarm == 4)
                {
                    Click.charges = Click.alarm;
                }
            }

            if (Click.count == 11)
            {
                Click.proverka += 13;
                Click.proverka_time++;
                if ((Click.need >= 0) && (Click.transport >= 0))
                {
                    Notice5.SetActive(!Notice5.activeSelf);

                }

                if (Click.need >= 7)
                {
                    Destroy(GameObject.Find("jammers for alarm"));
                }
                if (Click.need >= 8)
                {
                    Destroy(GameObject.Find("3_naparnika"));

                }
                if (Click.transport >= 3)
                {
                    Destroy(GameObject.Find("van"));
                }


            }
        }
        if (Click.charges == 4)
        {
            Click.points = UnityEngine.Random.Range(250, 1500);
            Click.click += Click.points;
            Click.fine = UnityEngine.Random.Range(0, 3);
            if (Click.fine == 3)
            {
                Click.click -= 1600;
            }
            Click.Hp -= 35;
            Click.Ea -= 35;
            Click.En -= 35;
            Click.clock += 3;
            Click.day++;
        }
    }
    public void To_Rob_a_Bank()
    {
        if (Click.proverka_time == 0)
        {
            Click.count = 12;
            if ((Click.need == 11))
            {
                Click.alarm += 4;
                Click.count += 13;
                if (Click.alarm == 4)
                {
                    Click.charges = Click.alarm;
                }
            }

            if (Click.count == 12)
            {
                Click.proverka += 14;
                Click.proverka_time++;
                if ((Click.need >= 0))
                {
                    Notice6.SetActive(!Notice6.activeSelf);

                }

                if (Click.need >= 9)
                {
                    Destroy(GameObject.Find("weapons"));
                }
                if (Click.need >= 10)
                {
                    Destroy(GameObject.Find("plan"));

                }
                if (Click.need >= 11)
                {
                    Destroy(GameObject.Find("hacker"));

                }


            }
        }

        if (Click.charges == 4)
        {
            Click.points = UnityEngine.Random.Range(1000, 6500);
            Click.click += Click.points;
            Click.fine = UnityEngine.Random.Range(0, 3);
            if (Click.fine == 3)
            {
                Click.click -= 7000;
            }
            Click.Hp -= 40;
            Click.Ea -= 40;
            Click.En -= 40;
            Click.day++;
            Click.clock += 3;
        }
    }



    public GameObject ChetchikEducation;
    public GameObject ChetchikEducation1;
    /*education*/
    public static void Class_3()

    {
        if (Click.check_need_leg == 0 && Click.click >= 350)
        {

            Click.click -= 350;
            Click.check_need_leg++;
            Click.education++;

        }
    }
    public static void Class_9()
    {
        if (Click.check_need_leg == 1 && Click.click >= 1200)
        {

            Click.click -= 1200;
            Click.check_need_leg++;
            Click.education++;

        }
    }
    public static void To_pass_on_the_right()
    {
        if (Click.check_need_leg == 2 && Click.click >= 2500)
        {

            Click.click -= 2500;
            Click.check_need_leg++;
            Click.education++;

        }
    }
    public static void Secondary_education()
    {
        if (Click.check_need_leg == 3 && Click.click >= 5000)
        {

            Click.click -= 5000;
            Click.check_need_leg++;
            Click.education++;

        }
    }
    public static void Higher_education()

    {
        if (Click.check_need_leg == 4 && Click.click >= 20000)
        {

            Click.click -= 20000;
            Click.check_need_leg++;
            Click.education++;

        }
    }
    public static void Special_courses()

    {
        if (Click.check_need_leg == 5 && Click.click >= 35000)
        {

            Click.click -= 35000;
            Click.check_need_leg++;
            Click.education++;

        }
    }
    public static void Study_abroad()
    {
        if (Click.check_need_leg == 6 && Click.click >= 45000)
        {

            Click.click -= 45000;
            Click.check_need_leg++;
            Click.education++;

        }
    }
    public  void Courses_in_Economics()
    {
        if (Click.check_need_leg == 7 && Click.click >= 60000)
        {

            Click.click -= 60000;
            Click.check_need_leg++;
            Click.education++;

            if (Click.education == 8)
            {
                ChetchikEducation.SetActive(true);
                ChetchikEducation1.SetActive(false);
            }
        }
    }





    public GameObject ChetchikHouse;
    public GameObject ChetchikHouse1;
    public static void Box()
    {

        if (Click.check_house == 0 && Click.click >= 10)
        {
            Click.click -= 10;
            Click.hous++;
            Click.check_house++;

        }
    }
    public static void Basement()
    {
        if (Click.check_house == 1 && Click.click >= 150)
        {
            Click.click -= 150;
            Click.hous++;
            Click.check_house++;

        }
    }
    public static void Attic()
    {
        if (Click.check_house == 2 && Click.click >= 300)
        {
            Click.click -= 300;
            Click.hous++;
            Click.check_house++;

        }
    }
    public static void Room()
    {

        if (Click.check_house == 3 && Click.click >= 800)
        {
            Click.payment++;
            Click.hous++;
            Click.check_house++;

        }
    }
    public static void Apartment()
    {
        if (Click.check_house == 4 && Click.click >= 1500)
        {
            Click.payment++;
            Click.hous++;
            Click.check_house++;

        }
    }
    public static void Buy_apartment()
    {
        if (Click.check_house == 5 && Click.click >= 65000)
        {
            Click.click -= 65000;
            Click.hous++;
            Click.check_house++;
            Click.payment++;

        }
    }
    public static void Office()
    {
        if (Click.check_house == 6 && Click.click >= 100000)
        {
            Click.click -= 100000;
            Click.hous++;
            Click.check_house++;

        }
    }
    public void House()
    {
        if (Click.check_house == 7 && Click.click >= 1500000)
        {
            Click.click -= 1500000;
            Click.hous++;
            Click.check_house++;
            if (Click.hous == 8)
            {
                ChetchikHouse.SetActive(true);
                ChetchikHouse1.SetActive(false);
            }

        }
    }
    /*many*/
    public static void Room_many()
    {
        if (Click.day == 30 && Click.payment == 1)
        {
            Click.click -= 800;
        }
    }
    public static void Apartment_many()
    {
        if (Click.day == 30 && Click.payment == 2)
        {
            Click.click -= 1500;
        }
    }

    public GameObject ChetchikTransport;
    public GameObject ChetchikTransport1;

    public static void Bike()
    {

        if (Click.check_transport == 0 && Click.click >= 400)
        {
            Click.click -= 400;
            Click.check_transport++;
            Click.transport++;

        }
    }
    public static void To_buy_a_car()
    {
        if (Click.check_transport == 1 && Click.click >= 4500)
        {
            Click.click -= 4500;
            Click.transport++;
            Click.check_transport++;

        }
    }
    public static  void Buy_a_van()
    {
        if (Click.check_transport == 2 && Click.click >= 7500)
        {
            Click.click -= 7500;
            Click.transport++;
            Click.check_transport++;

        }
    }
    public void To_buy_a_supercar()
    {
        if (Click.check_transport == 3 && Click.click >= 100000)
        {
            Click.click -= 100000;
            Click.transport++;
            Click.check_transport++;

            if (Click.transport == 4)
            {
                ChetchikTransport.SetActive(true);
                ChetchikTransport1.SetActive(false);

            }
        }
    }



    public static void Herbs()
    {
        if (Click.click >= 9 && Click.Hp < 100)
        {
            Click.click -= 9;
            Click.Hp += 15;
        }


    }
    public static void Buy_pills()
    {
        if (Click.click >= 15 && Click.Hp < 100)
        {
            Click.click -= 15;
            Click.Hp += 20;
        }

    }
    public static void Go_to_the_grandmother()
    {
        if (Click.click >= 40 && Click.Hp < 100)
        {
            Click.click -= 40;
            Click.Hp += 24;
        }

    }
    public static void Go_to_the_doctor()
    {
        if (Click.click >= 55 && Click.Hp < 100)
        {
            Click.click -= 55;
            Click.Hp += 35;
        }

    }
    public static void Visit_a_private_clinic()
    {
        if (Click.click >=150 && Click.Hp < 100)
        {
            Click.click -= 150;
            Click.Hp += 40;
        }

    }
    public static void To_be_treated_abroad_at_choclaty_pindosam()
    {
        if (Click.click >= 1000 && Click.Hp < 100)
        {
            Click.click -= 1000;
            Click.Hp += 100;
        }
    }



    public static void Eat_from_the_garbage()
    {
        if (Click.Ea < 100)
        {
            if (Click.En <= 100 && Click.Hp <= 100)
            {
                Click.Ea += 10;
                Click.Hp -= 5;
                Click.En += 2;
            }
        }

    }
    public static void Buy_a_cheburek()
    {
        if (Click.click >= 10 && Click.Ea < 100)
        {
            if (Click.En <= 100 && Click.Hp <= 100)
            {
                Click.click -= 10;
                Click.Ea += 15;
                Click.Hp -= 3;
                Click.En += 4;
            }
        }


    }

    public static void Eat_at_Mac()
    {
        if (Click.click >= 150 && Click.Ea < 100)
        {
            if (Click.En <= 100 && Click.Hp <= 100)
            {
                Click.click -= 150;
                Click.Ea += 17;
                Click.Hp -= 2;
                Click.En += 5;
            }
        }

    }
    public static void To_go_to_the_store()
    {
        if (Click.click >= 200 && Click.Ea < 100)
        {
            if (Click.En <= 100 && Click.Hp <= 100)
            {
                Click.click -= 200;
                Click.Ea += 20;
                Click.Hp -= 1;
                Click.En += 7;
            }
        }


    }
    public static void Go_to_the_restaurant()
    {
        if (Click.click >= 1000 && Click.Ea < 100)
        {
            if (Click.En <= 100 && Click.Hp <= 100)
            {
                Click.click -= 1000;
                Click.Ea += 50;
                Click.En += 10;
            }
        }


    }

    public static void Sleep()
    {
        if (Click.click > 0 && Click.En < 100)
        {
            if (Click.Ea <= 100 && Click.Hp <= 100)
            {
                Click.En += 10;
                Click.Hp += 5;
                Click.Ea -= 10;
            }
        }

    }
    public static void Jog_to_the_Park()
    {
        if (Click.click >= 10 && Click.En < 100)
        {
            if (Click.Ea <= 100 && Click.Hp <= 100)
            {
                Click.click -= 10;
                Click.En += 15;
                Click.Hp += 9;
                Click.Ea -= 9;
            }

        }

    }
    public static void Energy_drink()
    {
        if (Click.click >= 20 && Click.En < 100)
        {
            if (Click.Ea <= 100 && Click.Hp <= 100)
            {
                Click.click -= 20;
                Click.En += 30;
                Click.Hp -= 5;
                Click.Ea -= 5;
            }

        }

    }
    public static void Sign_up_for_fitness()
    {
        if (Click.click >= 100 && Click.En < 100)
        {
            if (Click.Ea <= 100 && Click.Hp <= 100)
            {
                Click.click -= 100;
                Click.En += 35;
                Click.Hp += 15;
                Click.Ea -= 10;
            }

        }

    }
    public static void Hire_a_personal_trainer()
    {
        if (Click.click >= 500 && Click.En < 100)
        {
            if (Click.Ea <= 100 && Click.Hp <= 100)
            {
                Click.click -= 500;
                Click.En += 50;
                Click.Hp += 20;
                Click.Ea -= 20;
            }
        }


    }




    public GameObject Chetchik;
    public GameObject Chetchik1;

    public static void Sneakers()
    {
        if (Click.check_need_cri == 0 && Click.click >= 35)
        {
            Click.click -= 35;
            Click.check_need_cri++;
            Click.need1++;

        }
    }
    public static void Special_costume()
    {
        if (Click.check_need_cri == 1 && Click.click >= 3500)
        {

            Click.click -= 3500;
            Click.check_need_cri++;
            Click.need1++;


        }
    }
    public static void Buy_a_computer()
    {
        if (Click.check_need_cri == 2 && Click.click >= 10000)
        {

            Click.click -= 10000;
            Click.check_need_cri++;
            Click.need1++;

        }
    }



    public static void Wir_cutters()
    {
        if (Click.check_need == 0 && Click.click >= 15)
        {

            Click.click -= 15;
            Click.check_need++;
            Click.need++;


        }
    }

    public static void Stocking_on_his_head()
    {
        if (Click.check_need == 1 && Click.click >= 80)
        {

            Click.click -= 80;
            Click.check_need++;
            Click.need++;

        }
    }
    public static void Hire_1_partner()
    {
        if (Click.check_need == 2 && Click.click >= 500)
        {

            Click.click -= 500;
            Click.check_need++;
            Click.need++;

        }
    }
    public static void The_master_key()
    {
        if (Click.check_need == 3 && Click.click >= 600)
        {

            Click.click -= 600;
            Click.check_need++;
            Click.need++;

        }
    }
    public static void Bulgarian()
    {
        if (Click.check_need == 4 && Click.click >= 800)
        {

            Click.click -= 800;
            Click.check_need++;
            Click.need++;

        }
    }
    public static void Masks()
    {
        if (Click.check_need == 5 && Click.click >= 1000)
        {

            Click.click -= 1000;
            Click.check_need++;
            Click.need++;

        }
    }
    public static void Buy_jammers_for_alarm()
    {
        if (Click.check_need == 6 && Click.click >= 2000)
        {

            Click.click -= 2000;
            Click.check_need++;
            Click.need++;

        }
    }

    public static void Hire_3_partner()
    {
        if (Click.check_need == 7 && Click.click >= 4000)
        {

            Click.click -= 4000;
            Click.check_need++;
            Click.need++;

        }
    }

    public static void Weapons()
    {
        if (Click.check_need == 8 && Click.click >= 4800)
        {

            Click.click -= 4800;
            Click.check_need++;
            Click.need++;

        }
    }
    public static void Plan()
    {
        if (Click.check_need == 9 && Click.click >= 5200)
        {

            Click.click -= 5200;
            Click.check_need++;
            Click.need++;

        }
    }
    public  void Hiring_a_hacker()
    {
        if (Click.check_need == 10 && Click.click >= 6900)
        {

            Click.click -= 6900;
            Click.check_need++;
            Click.need++;
            if (Click.need == 11 && Click.need1 == 3)
            {
                Chetchik.SetActive(true);
                Chetchik1.SetActive(false);
            }
        }
    }




    // Update is called once per frame
    void Update()
    {
        
        if (Click.proverka_time == 0)
        {
            if (Click.check_need_leg >= 1)
            {
                Destroy(GameObject.Find("Class 3"));
            }
            if (Click.check_need_leg >= 2)
            {
                Destroy(GameObject.Find("Class 9"));
            }
            if (Click.check_need_leg >= 3)
            {
                Destroy(GameObject.Find("To pass on the right"));
            }
            if (Click.check_need_leg >= 4)
            {
                Destroy(GameObject.Find(" Secondary Education"));
            }
            if (Click.check_need_leg >= 5)
            {
                Destroy(GameObject.Find("Higher Education"));
            }
            if (Click.check_need_leg >= 6)
            {
                Destroy(GameObject.Find("Special courses"));
            }
            if (Click.check_need_leg >= 7)
            {
                Destroy(GameObject.Find("Study abroad"));
            }
            if (Click.check_need_leg == 8)
            {
                Destroy(GameObject.Find("Courses in Economics"));
            }
            if (Click.check_house >= 1)
            {
                Destroy(GameObject.Find("Box"));
            }
            if (Click.check_house >= 2)
            {
                Destroy(GameObject.Find("Basement"));
            }
            if (Click.check_house >= 3)
            {
                Destroy(GameObject.Find("Attic"));
            }
            if (Click.check_house >= 4)
            {
                Destroy(GameObject.Find("room"));
            }
            if (Click.check_house >= 5)
            {
                Destroy(GameObject.Find("apartment"));
            }
            if (Click.check_house >= 6)
            {
                Destroy(GameObject.Find("Buy apartment"));
            }
            if (Click.check_house >= 7)
            {
                Destroy(GameObject.Find("office"));
            }
            if (Click.check_house == 8)
            {
                Destroy(GameObject.Find("house"));
            }
            if (Click.check_transport >= 1)
            {
                Destroy(GameObject.Find("Bike"));
            }
            if (Click.check_transport >= 2)
            {
                Destroy(GameObject.Find("To buy a car"));
            }
            if (Click.check_transport >= 3)
            {
                Destroy(GameObject.Find("Buy a van"));
            }
            if (Click.check_transport == 4)
            {
                Destroy(GameObject.Find("To buy a supercar"));
            }
        }

        if (Click.check_need >= 1)
        {
            Destroy(GameObject.Find("Wire cutters"));
        }
        if (Click.check_need >= 2)
        {
            Destroy(GameObject.Find("Stocking on his head"));
        }
        if (Click.check_need >= 3)
        {
            Destroy(GameObject.Find("Hire 1 partner"));
        }
        if (Click.check_need >= 4)
        {
            Destroy(GameObject.Find("The master key"));
        }
        if (Click.check_need >= 5)
        {
            Destroy(GameObject.Find("Bulgarian"));
        }
        if (Click.check_need >= 6)
        {
            Destroy(GameObject.Find("Masks"));
        }
        if (Click.check_need >= 7)
        {
            Destroy(GameObject.Find("Buy jammers for alarm"));
        }
        if (Click.check_need >= 8)
        {
            Destroy(GameObject.Find("Hire 3 partner"));
        }
        if (Click.check_need >= 9)
        {
            Destroy(GameObject.Find("Weapons"));
        }
        if (Click.check_need >= 10)
        {
            Destroy(GameObject.Find("Plan"));
        }
        if (Click.check_need == 11)
        {
            Destroy(GameObject.Find("Hiring a hacker"));
        }
        if (Click.check_need_cri >= 1)
        {
            Destroy(GameObject.Find("sneakers"));
        }
        if (Click.check_need_cri >= 2)
        {
            Destroy(GameObject.Find("Special costume"));
        }
        if (Click.check_need_cri == 3)
        {
            Destroy(GameObject.Find("Buy a computer"));
        }
     

    }
}
