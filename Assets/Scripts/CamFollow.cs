using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public Transform CamMovement;

    private void Update()
    {
        this.transform.position = new Vector3(CamMovement.position.x, CamMovement.position.y, this.transform.position.z);


    }
}
