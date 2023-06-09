using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MixingMiniGame : MonoBehaviour
{

    bool Pause = false;
   

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
    [SerializeField] float mixHookSize = 0.15f;
    [SerializeField] float mixHookPower = 50f;
    float hookProgress;
    float hookPullVelocity;
    [SerializeField] float hookPullPower = 0.01f;
    [SerializeField] float hookGravPower = 0.005f;
    [SerializeField] float hookProgDegradationPower = 25f;

    [SerializeField] SpriteRenderer hookSpriteRenderer;

    [Header("ProgBar")]
    [SerializeField] Transform progressBarContainer;

    [SerializeField] float failTimer = 10f;

    private void Start()
    {
       
        //Resize();
    }

    private void Update()
    {
        if (Pause) { return; }
        Pot();
        Hook();
        ProgressCheck();
    }

    private void Resize()
    {
        Bounds b = hookSpriteRenderer.bounds;
        float yScale = b.size.y;
        Vector3 ls = mixHook.localScale;
        float distance = Vector3.Distance(topPivot.position, bottomPivot.position);
        ls.y = (distance / yScale * mixHookSize);
        mixHook.localScale = ls;
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

        if (hookPosition - mixHookSize / 3 <= 0f && hookPullVelocity < 0f) //Prevent weird delay of hook not rising after going back down
        {
            hookPullVelocity = 0f;
        }

        if (hookPosition + mixHookSize / 3 >= 1f && hookPullVelocity > 0f) //Prevent weird delay of hook not rising after going back down or back up
        {
            hookPullVelocity = 0f;
        }
        hookPosition = Mathf.Clamp(hookPosition, mixHookSize / 3, 1 - mixHookSize / 3);
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

    void ProgressCheck()
    {
        Vector3 ls = progressBarContainer.localScale;
        ls.y = hookProgress;
        progressBarContainer.localScale = ls;

        float min = hookPosition - mixHookSize / 3;
        float max = hookPosition + mixHookSize / 3;

        if (min < potPos && potPos < max)
        {
            hookProgress += mixHookPower * Time.deltaTime; //Increase progress if pot is in hook area
            
        }


        else
        {
            hookProgress -= hookProgDegradationPower * Time.deltaTime; //Decrease if pot is outside prog area
            
            /*failTimer -= Time.deltaTime;
            if(failTimer < 0)
            {
                Lose();
            }*/
        }

        if (hookProgress >= 420f)
        {
            //StartCoroutine(Win());
        }

        hookProgress = Mathf.Clamp(hookProgress, 0f, 420f);
    }

        /*IEnumerator Win()
        {
            Pause = true;
        yield return new WaitForSeconds(1.5f);
        
            Debug.Log("Mixture done");
        }

        void Lose()
        {
            Pause = true;
            Debug.Log("Mixture fail");
        }*/
    }


