using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// make sure to name your C# file the same as your class name. In this case Move.cs 
public class Move : MonoBehaviour 
{
    // change your serial port
    //SerialPort sp = new SerialPort("COM5", 9600);
    Rigidbody m_Rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        //sp.Open();
        //sp.ReadTimeout = 100; // In my case, 100 was a good amount to allow quite smooth transition.           //dit is puur arduino, just leave it be
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {/*
        //if (Input) //GetKeyDown voor toetsen toetsenbord, los van arduino
        if (sp.IsOpen){   //checkt of port open is - misschien nog dicht doen? 
            try{
                // When left button is pushed
                if(sp.ReadByte()==0){ 
                    print(sp.ReadByte());
                    //transform.Translate(Vector3.left * Time.deltaTime * 3);
                    m_Rigidbody.AddForce(Time.deltaTime * -300, 0, 0);
                }
                // When right button is pushed
                if(sp.ReadByte()==1){
                    print(sp.ReadByte());
                   m_Rigidbody.AddForce(Time.deltaTime * 300, 0, 0);
                }
            }
            catch (System.Exception){
               
            }

        }*/
    }
}
