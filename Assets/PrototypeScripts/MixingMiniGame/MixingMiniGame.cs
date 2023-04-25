using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MixingMiniGame : MonoBehaviour
{
    [Header("Pot")]
    [SerializeField] Transform topPivot;
    [SerializeField] Transform bottomPivot;

    [SerializeField] Transform pot;
    // Start is called before the first frame update
    float potPos;
    float potDest;

    float potTimer;
    [SerializeField] float timerMultiplicator = 3f;

    float potSpeed;
    [SerializeField] float smoothMotion = 1f;

    [Header("MixHook")]
    [SerializeField] Transform mixHook;
    float hookPosition;
    [SerializeField] float mixHookSize = 0.1f;
    [SerializeField] float mixHookPower = 5f;
    float hookProgress;
    float hookPullVelocity;
    [SerializeField] float hookPullPower = 0.01f;
    [SerializeField] float hookGravPower = 0.005f;
    [SerializeField] float hookProgDegradationPower = 0.1f;



    private void Update()
    {
        Pot();
        Hook();
    }

    void Hook()
    {
        if (Input.GetMouseButton(0))
        {
            print("pressed");
            hookPullVelocity += hookPullPower * Time.deltaTime; //If player press input, this affects strength of hook
        }
        hookPullVelocity -= hookGravPower * Time.deltaTime; //gravity to pull hook down

        hookPosition += hookPullVelocity;
        hookPosition = Mathf.Clamp(hookPosition, 0, 1);
        mixHook.position = Vector3.Lerp(bottomPivot.position, topPivot.position, hookPosition);
    }

    void Pot()
    {
        //Simulate "struggling" motion
        potTimer -= Time.deltaTime;
        if (potTimer < 0f)
        {
            //Check if there is no time left
            potTimer = UnityEngine.Random.value * timerMultiplicator;
            potDest = UnityEngine.Random.value;
        }

        potPos = Mathf.SmoothDamp(potPos, potDest, ref potSpeed, smoothMotion);
        pot.position = Vector3.Lerp(bottomPivot.position, topPivot.position, potPos); //Move the pot
    }
}
