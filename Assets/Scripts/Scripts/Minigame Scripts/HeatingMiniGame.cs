using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeatingMiniGame : MonoBehaviour
{
    [SerializeField] Transform topPivot;
    [SerializeField] Transform botPivot;

    [SerializeField] Transform meter;
    float meterSpeed;
    //float heatingDuration = 3f;
    [SerializeField] float heatingPull = 0.001f;
    [SerializeField] float heatingGrav = 0.0005f;
    float meterPos;

    float meterPower;
    float meterSize;
    float heatingProgress;
    [SerializeField] Transform progContainer;

    HeaterTrigger ht;


    float meterProg;
    // Start is called before the first frame update
    void Start()
    {
        ht = FindObjectOfType<HeaterTrigger>();
    }

    // Update is called once per frame
    void Update()
    {
        Cook();
    }

    void Cook()
    {
        if (Input.GetMouseButton(0))
        {
            meterSpeed += heatingPull * Time.deltaTime;
            print("Pulling");
        }
        meterSpeed -= heatingGrav * Time.deltaTime;
        meterPos += meterSpeed;

        if(meterPos - meterSize/2 <= 0f && meterSpeed < 0f)
        {
            meterSpeed = 0f;
        }

        if (meterPos - meterSize / 2 >= 1f && meterSpeed > 0f)
        {
            meterSpeed = 0f;
        }

        meterPos = Mathf.Clamp(meterPos, 0, 1);
        meter.position = Vector3.Lerp(botPivot.position, topPivot.position,meterPos );
    }

    void ProgCheck()
    {
        Vector3 ls = progContainer.localScale;
        ls.z = heatingProgress;
        progContainer.localScale = ls;

        if (ht.white)
        {

        }
    }

    

   
}
