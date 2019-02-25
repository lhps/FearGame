using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tirarVida : MonoBehaviour
{
   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            PLAYER.VIDA = PLAYER.VIDA - 20;
            Debug.Log("perdeu 20 de vida");
        }
        if(PLAYER.VIDA <= 0)
        {
            Debug.Log("morreu");
        }
    }
}
