using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// make sure to name your C# file the same as your class name. In this case Move.cs 
public class MoveTest : MonoBehaviour
{
    // change your serial port
    //SerialPort sp = new SerialPort("COM5", 9600);
    
    // Start is called before the first frame update
    void Start()
    {
       // sp.Open();
        //sp.ReadTimeout = 100; // In my case, 100 was a good amount to allow quite smooth transition. 
    }

    // Update is called once per frame
    void Update()
    {/*
        if (sp.IsOpen){
            try{
                // When left button is pushed
                if(sp.ReadByte()==1){
                    print(sp.ReadByte());
                    transform.Translate(Vector3.left * Time.deltaTime * 5);
                }
                // When right button is pushed
                if(sp.ReadByte()==2){
                    print(sp.ReadByte());
                    transform.Translate(Vector3.right * Time.deltaTime * 5);
                }
            }
            catch (System.Exception){
               
            }

        }*/
    }
}






