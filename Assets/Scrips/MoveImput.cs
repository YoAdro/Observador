using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveImput : MonoBehaviour
{
    [SerializeField] private float velocity;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D)) //Solo cambien el boton para los otros
        {

            transform.position += Vector3.right * (Time.deltaTime * velocity);
            //Para el horizontal ponga el cambio de numero en z

        }

        if (Input.GetKey(KeyCode.A)) //Solo cambien el boton para los otros
        {

            transform.position += Vector3.left * (Time.deltaTime * velocity);
            //Para el horizontal ponga el cambio de numero en z

        }
    }
}
