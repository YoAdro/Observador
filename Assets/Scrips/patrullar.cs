using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patrullar : MonoBehaviour
{
    [SerializeField] private float MoveSpeed;
    [SerializeField] private Transform[] puntosMovimiento;
    [SerializeField] private float DistanciaMinima;
    private int SiguientePaso = 0;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        Girar();
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, puntosMovimiento[SiguientePaso].position, MoveSpeed * Time.deltaTime);
        if (Vector2.Distance(transform.position, puntosMovimiento[SiguientePaso].position) < DistanciaMinima)
        {
            SiguientePaso += 1;
            if (SiguientePaso >= puntosMovimiento.Length)
            {
                SiguientePaso = 0;
                Girar();
            }

        }
    }

        private void Girar()
        {
            if (transform.position.x < puntosMovimiento[SiguientePaso].position.x)
            {
                spriteRenderer.flipX = true;
            }
            else
            {
                spriteRenderer.flipX = false;
            }
        }
    }

