using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MixingMiniGame : MonoBehaviour
{
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

    private void Update()
    {
        //Simulate "struggling" motion
        potTimer -= Time.deltaTime;
        if(potTimer < 0f)
        {
            //Check if there is no time left
            potTimer = UnityEngine.Random.value * timerMultiplicator;
            potDest = UnityEngine.Random.value;
        }

        potPos = Mathf.SmoothDamp(potPos, potDest, ref potSpeed, smoothMotion);
        pot.position = Vector3.Lerp(bottomPivot.position, topPivot.position, potPos); //Move the pot
    }
}
