﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowPlayer : MonoBehaviour
{
    //Interface interface_ref;

    PlayerMovimento playerMovimentacao_ref;

    public bool devagar = false;

    [SerializeField]
    private float velocidadeLentaInicial;

    [SerializeField]
    private float velocidadeLentaMax;

    public int recuperacao;

    public int perder;

    // Start is called before the first frame update

    void Awake()
    {
        playerMovimentacao_ref = GetComponent<PlayerMovimento>();


    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (devagar)
        {
            velocidadeLentaInicial += Time.deltaTime;


            if (velocidadeLentaInicial >= velocidadeLentaMax)
            {

                devagar = false;
                playerMovimentacao_ref.speed += recuperacao;

                velocidadeLentaInicial = 0;
            }
        }
    }

   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("RedeDepesca"))
        {
            if (playerMovimentacao_ref.speed >= 6)
            {
                playerMovimentacao_ref.speed -= perder;
                devagar = true;
            }


        }
    }
}
