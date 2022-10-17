using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movepersonagem : MonoBehaviour
{
    public GameObject aviao;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // metodo que é chamado quando a tela é
    void Update()
    {


     if (Input.GetKey(KeyCode.UpArrow)){
        transform.Translate(new Vector3(0,0.1f,0));
     }
     if(Input.GetKey(KeyCode.DownArrow)){
        transform.Translate(new Vector3(0,-0.1f,0));
     }
     if(Input.GetKey(KeyCode.LeftArrow)){
        transform.Translate(new Vector3(-0.1f,0,0));
     }
     if(Input.GetKey(KeyCode.RightArrow)){
        transform.Translate(new Vector3(0.1f,0,0));
     }
    }

}
