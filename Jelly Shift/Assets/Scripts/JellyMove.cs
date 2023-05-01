using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JellyMove : MonoBehaviour
{
    private Camera cam;

    public Rigidbody rb; 

    public float LerpValue; 

    public float minY, maxY;

    public float minX, maxX;

    public float speed;

    private bool isGameEnded = false; 

    void Start()
    {

        cam = Camera.main; //camera tag'ini start kısmında söz konusu kıldık. maincamera tag'ine iye olan objeyi ediniyoruz.

    }

    
    void Update()
    {
        if (!isGameEnded) //şayet oyun sonlanmadıysa
        {
            rb.velocity = Vector3.forward * speed * Time.deltaTime; //ilerleme kodu.
        }

        if (Input.GetButton("Fire1")) //mouse'un sol tarafına tıkladığımız zaman çağırsın demek.s
        {
            ChangeScale();
        }
            
    }

    public void ChangeScale()
    {
        Vector3 mousePos = Input.mousePosition;

        mousePos.z = 10; //mouse pozisyonumuza bir derinlik katmamız icap ettiğinden ötürü bu kodu girdik.

        Vector3 moveVec = cam.ScreenToWorldPoint(mousePos); // mouse'umuzun hareketini screenworldpoint'e çeviriyoruz.

        float x = transform.localScale.x;

        moveVec.z = transform.localScale.z;

        moveVec.y *= 2f;

        Debug.Log("Y : " + moveVec.y);

        moveVec.y = Mathf.Clamp(moveVec.y, minY, maxY); //mathf.clamp, biçilen değerlerin minimum ve maksimum değerlerini aşıp aşmadığımızdan emin olmamıza yarayan bir fonksiyondur.

        x = maxY / moveVec.y;

        Debug.Log("X :" + x);

        moveVec.x = Mathf.Clamp(x, minX, maxX); 

        transform.localScale = moveVec;

        GhostJelly.instance.ChangeScaleOfTheGhost(moveVec);
    }
}
