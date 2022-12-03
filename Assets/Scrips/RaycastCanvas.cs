using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastCanvas : MonoBehaviour
{
    public Canvas info;
    public AudioClip loquendo;
    
    
    public void OnRaycastEnter()
    {
        Destroy(gameObject);
    }

    public void OnRaycasExit()
    {

    }
}
