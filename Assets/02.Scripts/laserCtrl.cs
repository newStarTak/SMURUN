using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserCtrl : MonoBehaviour
{
    public float laserSpeed = 1000f;
    private Transform endPos;

    // Start is called before the first frame update
    void Start()
    {
        endPos = GameObject.FindGameObjectWithTag("LASER_ENDPOS").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, endPos.position, laserSpeed * Time.deltaTime);
    }
}
