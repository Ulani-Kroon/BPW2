using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Code van Ralph Burgers

public class SwitchTrigger : MonoBehaviour
{
    //public Animator Animator;
    public GameObject DayStuff;
    public GameObject NightStuff;
    public GameObject PostProsDAY;
    public GameObject PostProsNIGHT;

    public Material DaySkyBox;
    public Material NightSkyBox;

    private void Update()
    {
        
        //Gaat naar dag
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            //Animator.SetTrigger("MushroomAppear");
            //Fireflies.GetComponent<VisualEffect>().enabled = true;

            RenderSettings.skybox = DaySkyBox; 

            PostProsDAY.SetActive(true);
            PostProsNIGHT.SetActive(false);

            DayStuff.SetActive(true);
            NightStuff.SetActive(false);
        }

                //Gaat naar nacht
        if (Input.GetKeyDown(KeyCode.Q))
        {
            //Animator.SetTrigger("MushroomHide");
            //Fireflies.GetComponent<VisualEffect>().enabled = false;
           
            RenderSettings.skybox = NightSkyBox;

            PostProsDAY.SetActive(false);
            PostProsNIGHT.SetActive(true);

            DayStuff.SetActive(false);
            NightStuff.SetActive(true);
        }

    }
}