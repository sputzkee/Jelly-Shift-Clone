using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostJelly : MonoBehaviour
{
    public static GhostJelly instance;

    public Transform[] ghostPoses;

    private int index = 0;

    private void Awake()
    {
       if(instance == null)
       {
            instance = this;
       }
    }
    public void ChangeScaleOfTheGhost(Vector3 scale)
    {
        transform.localScale = scale;
    }
    public void ChangePosOfTheGhost()
    {
        index++;
        if (ghostPoses.Length>index)
        {
            transform.position = ghostPoses[index].transform.position;
        }
    }
}
