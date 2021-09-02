using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atacar : MonoBehaviour
{
    public Animator mountro;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)){
            mountro.SetTrigger("atacar");
        
        }        
    }
}
