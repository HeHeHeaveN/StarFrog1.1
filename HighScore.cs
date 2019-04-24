using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{


    public PlayerController partidaActual;
    public float puntuacion;

    public Text highScore1;
    public Text highScore2;
    public Text highScore3;
    public Text highScore4;
    public Text highScore5;
    public Text highScore6;
    public Text highScore7;
    public Text highScore8;
    public Text highScore9;
    public Text highScore10;

    public float highScore1Anterior;
    public float highScore2Anterior;
    public float highScore3Anterior;
    public float highScore4Anterior;
    public float highScore5Anterior;
    public float highScore6Anterior;
    public float highScore7Anterior;
    public float highScore8Anterior;
    public float highScore9Anterior;


    void Start()
    {

        highScore1Anterior = PlayerPrefs.GetFloat("HighScore1");
        highScore2Anterior = PlayerPrefs.GetFloat("HighScore2");
        highScore3Anterior = PlayerPrefs.GetFloat("HighScore3");
        highScore4Anterior = PlayerPrefs.GetFloat("HighScore4");
        highScore5Anterior = PlayerPrefs.GetFloat("HighScore5");
        highScore6Anterior = PlayerPrefs.GetFloat("HighScore6");
        highScore7Anterior = PlayerPrefs.GetFloat("HighScore7");
        highScore8Anterior = PlayerPrefs.GetFloat("HighScore8");
        highScore9Anterior = PlayerPrefs.GetFloat("HighScore9");

        highScore1.text = PlayerPrefs.GetFloat("HighScore1").ToString();
        highScore2.text = PlayerPrefs.GetFloat("HighScore2").ToString();
        highScore3.text = PlayerPrefs.GetFloat("HighScore3").ToString();
        highScore4.text = PlayerPrefs.GetFloat("HighScore4").ToString();
        highScore5.text = PlayerPrefs.GetFloat("HighScore5").ToString();
        highScore6.text = PlayerPrefs.GetFloat("HighScore6").ToString();
        highScore7.text = PlayerPrefs.GetFloat("HighScore7").ToString();
        highScore8.text = PlayerPrefs.GetFloat("HighScore8").ToString();
        highScore9.text = PlayerPrefs.GetFloat("HighScore9").ToString();
        highScore10.text = PlayerPrefs.GetFloat("HighScore10").ToString();




    }



    // Update is called once per frame
    void Update()
    {

        Start();

        puntuacion = partidaActual.puntuacion;


        if (puntuacion >= PlayerPrefs.GetFloat("HighScore1"))
        {
            highScore10.text = highScore9Anterior.ToString();
            highScore9.text = highScore8Anterior.ToString();
            highScore8.text = highScore7Anterior.ToString();
            highScore7.text = highScore6Anterior.ToString();
            highScore6.text = highScore5Anterior.ToString();
            highScore5.text = highScore4Anterior.ToString();
            highScore4.text = highScore3Anterior.ToString();
            highScore3.text = highScore2Anterior.ToString();
            highScore2.text = highScore1Anterior.ToString();

            PlayerPrefs.SetFloat("HighScore1", puntuacion);
            highScore1.text = puntuacion.ToString();
            

        }

        else if (puntuacion >= PlayerPrefs.GetFloat("HighScore2") && puntuacion < PlayerPrefs.GetFloat("HighScore1"))
        {

            highScore10.text = highScore9Anterior.ToString();
            highScore9.text = highScore8Anterior.ToString();
            highScore8.text = highScore7Anterior.ToString();
            highScore7.text = highScore6Anterior.ToString();
            highScore6.text = highScore5Anterior.ToString();
            highScore5.text = highScore4Anterior.ToString();
            highScore4.text = highScore3Anterior.ToString();
            highScore3.text = highScore2Anterior.ToString();            

            PlayerPrefs.SetFloat("HighScore2", puntuacion);
            highScore2.text = puntuacion.ToString();


        }

        else if (puntuacion >= PlayerPrefs.GetFloat("HighScore3") && puntuacion < PlayerPrefs.GetFloat("HighScore2"))
        {

            highScore10.text = highScore9Anterior.ToString();
            highScore9.text = highScore8Anterior.ToString();
            highScore8.text = highScore7Anterior.ToString();
            highScore7.text = highScore6Anterior.ToString();
            highScore6.text = highScore5Anterior.ToString();
            highScore5.text = highScore4Anterior.ToString();
            highScore4.text = highScore3Anterior.ToString();
            
            PlayerPrefs.SetFloat("HighScore3", puntuacion);
            highScore3.text = puntuacion.ToString();


        }

        else if (puntuacion >= PlayerPrefs.GetFloat("HighScore4") && puntuacion < PlayerPrefs.GetFloat("HighScore3"))
        {

            highScore10.text = highScore9Anterior.ToString();
            highScore9.text = highScore8Anterior.ToString();
            highScore8.text = highScore7Anterior.ToString();
            highScore7.text = highScore6Anterior.ToString();
            highScore6.text = highScore5Anterior.ToString();
            highScore5.text = highScore4Anterior.ToString();

            PlayerPrefs.SetFloat("HighScore4", puntuacion);
            highScore4.text = puntuacion.ToString();


        }

        else if (puntuacion >= PlayerPrefs.GetFloat("HighScore5") && puntuacion < PlayerPrefs.GetFloat("HighScore4"))
        {

            highScore10.text = highScore9Anterior.ToString();
            highScore9.text = highScore8Anterior.ToString();
            highScore8.text = highScore7Anterior.ToString();
            highScore7.text = highScore6Anterior.ToString();
            highScore6.text = highScore5Anterior.ToString();

            PlayerPrefs.SetFloat("HighScore5", puntuacion);
            highScore5.text = puntuacion.ToString();


        }

        else if (puntuacion >= PlayerPrefs.GetFloat("HighScore6") && puntuacion < PlayerPrefs.GetFloat("HighScore5"))
        {

            highScore10.text = highScore9Anterior.ToString();
            highScore9.text = highScore8Anterior.ToString();
            highScore8.text = highScore7Anterior.ToString();
            highScore7.text = highScore6Anterior.ToString();


            PlayerPrefs.SetFloat("HighScore6", puntuacion);
            highScore6.text = puntuacion.ToString();


        }

        else if (puntuacion >= PlayerPrefs.GetFloat("HighScore7") && puntuacion < PlayerPrefs.GetFloat("HighScore6"))
        {

            highScore10.text = highScore9Anterior.ToString();
            highScore9.text = highScore8Anterior.ToString();
            highScore8.text = highScore7Anterior.ToString();


            PlayerPrefs.SetFloat("HighScore7", puntuacion);
            highScore7.text = puntuacion.ToString();


        }

        else if (puntuacion >= PlayerPrefs.GetFloat("HighScore8") && puntuacion < PlayerPrefs.GetFloat("HighScore7"))
        {

            highScore10.text = highScore9Anterior.ToString();
            highScore9.text = highScore8Anterior.ToString();

            PlayerPrefs.SetFloat("HighScore8", puntuacion);
            highScore8.text = puntuacion.ToString();


        }

        else if (puntuacion >= PlayerPrefs.GetFloat("HighScore9") && puntuacion < PlayerPrefs.GetFloat("HighScore8"))
        {

            highScore10.text = highScore9Anterior.ToString();

            PlayerPrefs.SetFloat("HighScore9", puntuacion);
            highScore9.text = puntuacion.ToString();


        }

        else if (puntuacion >= PlayerPrefs.GetFloat("HighScore10") && puntuacion < PlayerPrefs.GetFloat("HighScore9"))
        {

            PlayerPrefs.SetFloat("HighScore10", puntuacion);
            highScore10.text = puntuacion.ToString();

        }

    }

    public void ReiniciarPuntuacion()
    {
        PlayerPrefs.DeleteAll();
    }
}
