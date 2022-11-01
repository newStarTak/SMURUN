using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlopeCtrl : MonoBehaviour
{
    public float slopeSpeed = 10.0f;
    private Transform betweenPos;
    private Transform endPos;

    public bool isTime = true;

    // Start is called before the first frame update
    void Start()
    {
        betweenPos = GameObject.FindGameObjectWithTag("SLOPE_BETWEENPOS").transform;
        endPos = GameObject.FindGameObjectWithTag("SLOPE_ENDPOS").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, endPos.position, slopeSpeed * Time.deltaTime);

        /* For Debug
        if(transform.position == endPos.position && isTime)
        {
            Debug.Log(Time.time);
            isTime = false;
        }
        //*/
    }
}
