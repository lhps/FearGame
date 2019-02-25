using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLAYER : MonoBehaviour
{
    //variáveis staticas não aparecem no inspector
    public static int VIDA;
    public int VidaInicial = 100;

    private void Start()
    {
        VIDA = VidaInicial;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
