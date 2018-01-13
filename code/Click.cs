using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Click : MonoBehaviour {
    

    public GameObject Died;
    public GameObject Alarm;

    public Slider hp;
    public Slider ea;
    public Slider en;
    public Text Many;
    public Text Day;
    public Text Clock;
    public Text HP_w;
    public Text EA_w;
    public Text EN_w;
    public Text Timer;
    
    public static int click; //счетчик очков
    public static int day; //счетчик дней
    public static int clock; //счетчик часов
    public static int Hp = 100; //счетчик жизни
    public static int Ea = 100; //счетчик еды
    public static int En = 100; //счетчик энергии
    public static int hous = 0; //счетчик купленных домов
    public static int education = 0; //счетчик пройденного образование
    public static int need = 0; //счетчик купленных товаров криминал
    public static int need1 = 0; //счетчик купленных товаров обычная
    
    public static int check_house = 0; //проверка на то чтоб нельзя было купить следующий дом без предыдущего
    public static int points; //проверка криминальной работы с рандомом
    public static int fine; //проверка криминальной работы с штрафом 
    public static int payment = 0; //проверка снята ли комната или квартира
    public static int check_need = 0; //проверка на то чтоб нельзя было купить следующий товар в магазине без предыдущего
    public static int check_need_cri = 0; //проверка на то чтоб нельзя было купить следующий крименальный товар в магазине без предыдущего
    public static int check_need_leg = 0; //проверка на то чтоб нельзя было пройти следующее обучение в магазине без предыдущего
    
    public static int alarm = 0; //проверка купленно ли всё для того чтоб давали деньги
    public static int charges = 0; //проверка купленно ли всё для того чтоб давали деньги для  работ
    public static int count = 0; //проверкa уведомлений для работ
    public static int proverka = 0;
    public static int proverka_time = 0;
    public static int button = 0;
    public static int transport = 0; //счетчик купленных машин
    public static int check_transport = 0; //проверка на то чтоб нельзя было купить следующию машину без предыдущей
    private Save sv = new Save();

  
    public void ContinueGame ()
    {
        
            Load();
            Application.LoadLevel("game");
        

    }
    public void Exit ()
    {
        OnApplicationQuit();
        Application.Quit();

    }
    public void NewGameClick()
    {
        New_load();     
    }
    public void New_load ()
    {
        click = 0;
        day = 0;
        clock = 0;
        Hp = 100;
        Ea = 100;
        En = 100;
        hous = 0;
        education = 0;
        need = 0;
        need1 = 0;
        transport = 0;
        check_house = 0;
        points = 0;
        fine = 0;
        payment = 0;
        check_need = 0;
        check_need_cri = 0;
        check_need_leg = 0;
        alarm = 0;
        charges = 0;
        count = 0;
        proverka = 0;
        proverka_time = 0;
        button = 0;
        check_transport = 0;
        Application.LoadLevel("game");
    }
    void OnMouseUpAsButton()
    {
        switch (gameObject.name)
        {
            case "next":
                Application.LoadLevel("game");
                break;
        }

    }


    
    public void Update()
    {
        hp.value = Hp;
        ea.value = Ea;
        en.value = En;
        hp.maxValue = 100;
        ea.maxValue = 100;
        en.maxValue = 100;
        Many.text = click + "$";
        HP_w.text = hp.value + " ";
        EN_w.text = en.value + " ";
        EA_w.text = ea.value + " ";
        Day.text = day + "days";
        Clock.text = clock + ":00";
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OnApplicationQuit();
            Application.LoadLevel("menu");
           
           
        }
        if (clock >= 24)
        {
            clock = 0;
        }
        if (day > 30)
        {
            day = 1;
        }
        if (Hp >= 100)
            Hp = 100;
        if (Ea >= 100)
            Ea = 100;
        if (En >= 100)
            En = 100;
        if (Hp < 0 || En < 0 || Ea < 0)
        {
            Died.SetActive(true);
            Alarm.SetActive(false);
        }
    }


    private void OnApplicationQuit()
    {
        Savve();
    }
    public void Load ()
    {
        if (PlayerPrefs.HasKey("Save_13"))
        {
            sv = JsonUtility.FromJson<Save>(PlayerPrefs.GetString("Save_13"));
            click = sv.click;
            day = sv.day;
            clock = sv.clock;
            Hp = sv.Hp;
            Ea = sv.Ea;
            En = sv.En;
            hous = sv.hous;
            education = sv.education;
            need = sv.need;
            need1 = sv.need1;
            transport = sv.transport;
            check_house = sv.check_house;
            points = sv.points;
            fine = sv.fine;
            payment = sv.payment;
            check_need = sv.check_need;
            check_need_cri = sv.check_need_cri;
            check_need_leg = sv.check_need_leg;
            alarm = sv.alarm;
            charges = sv.charges;
            count = sv.count;
            proverka = sv.proverka;
            proverka_time = sv.proverka_time;
            button = sv.button;
            check_transport = sv.check_transport;
        }
    }
    public void Savve ()
    {
        sv.click = click;
        sv.day = day;
        sv.clock = clock;
        sv.Hp = Hp;
        sv.Ea = Ea;
        sv.En = En;
        sv.hous = hous;
        sv.education = education;
        sv.need = need;
        sv.need1 = need1;
        sv.transport = transport;
        sv.check_house = check_house;
        sv.points = points;
        sv.fine = fine;
        sv.payment = payment;
        sv.check_need = check_need;
        sv.check_need_cri = check_need_cri;
        sv.check_need_leg = check_need_leg;
        sv.alarm = alarm;
        sv.charges = charges;
        sv.count = count;
        sv.proverka = proverka;
        sv.proverka_time = proverka_time;
        sv.button = button;
        sv.check_transport = check_transport;
        PlayerPrefs.SetString("Save_13", JsonUtility.ToJson(sv));
    }
    [Serializable]
    public class Save
    {
        public int click;
        public int day;
        public int clock;
        public int Hp; 
        public int Ea; 
        public int En; 
        public int hous; 
        public int education; 
        public int need; 
        public int need1; 
        public int transport; 
        public int check_house; 
        public int points;
        public int fine; 
        public int payment;
        public int check_need; 
        public int check_need_cri;
        public int check_need_leg; 
        public int check_transport; 
        public int alarm; 
        public int charges;
        public int count;
        public int proverka;
        public int proverka_time;
        public int button;
    }
}
