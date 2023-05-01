using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform target; //hedef

    public Vector3 offset; //mesafe 

    public float LerpValue; //pürüzsüz takibat

    void Start()
    {
        Vector3 desPos = target.position + offset; //istenilen pozisyon eşittir hedef pozisyon artı dengeleme.

        transform.position = Vector3.Lerp(transform.position, desPos, LerpValue); //kameranın pozisyonunu Vector3.Lerp'lüyoruz. paranteze pozisyon, istenilen pozisyon ve lerp ifadelerini yazıyoruz.
    }

    
    void LateUpdate()
    {
        
    }
}
