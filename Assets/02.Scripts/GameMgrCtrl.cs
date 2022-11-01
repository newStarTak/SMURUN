using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMgrCtrl : MonoBehaviour
{
    public float slopeGenerateRate;
    public float slopeLifeTime;

    public GameObject[] Slopes;
    public Transform slopeStartPos;

    public GameObject laser_alert_prefab;
    public GameObject laser_prefab;
    public Transform laserStartPos;
    public Transform laserEndPos;

    private int rand;

    void Start()
    {
        //Debug.Log(Slopes.Length);
        //slopeStartPos = GameObject.FindGameObjectWithTag("STARTPOS").transform;

        GenerateSlope();
        Invoke("ShootLaser", 5f);
    }

    public void GenerateSlope()
    {
        rand = (int)Random.Range(0, Slopes.Length);

        /* Wrong -> This method destroys "asset" itself, not "GameObject"!
        GameObject targetSlope = Slopes[rand];
        Instantiate(targetSlope, targetSlope.transform.position, Quaternion.identity);
        Destroy(targetSlope, generateTime);
        */

        GameObject targetSlope = Instantiate(Slopes[rand], slopeStartPos.position, Quaternion.identity);
        
        Destroy(targetSlope, slopeLifeTime);

        Invoke("GenerateSlope", slopeGenerateRate);
    }

    public void ShootLaser()
    {
        GameObject laser_alert = Instantiate(laser_alert_prefab, laserEndPos.position, Quaternion.identity);

        Destroy(laser_alert, 1.0f);

        Invoke("RealLaser", 1.3f);

        Invoke("ShootLaser", 5f);
    }

    public void RealLaser()
    {
        GameObject laser = Instantiate(laser_prefab, laserStartPos.position, Quaternion.identity);

        Destroy(laser, 0.4f);
    }
}
