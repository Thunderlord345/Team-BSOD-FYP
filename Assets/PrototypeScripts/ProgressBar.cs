using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    [SerializeField] GameObject playerGO;
    [SerializeField] GameObject finishGO;

    Image progressBar;
    float maxDistance;

    PlayerController player;

    // Start is called before the first frame update
    void Start()
    {
        progressBar = GetComponent<Image>();
        maxDistance = finishGO.transform.position.x;

        progressBar.fillAmount = playerGO.transform.position.x / maxDistance;

        player = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(progressBar.fillAmount < 1)
        {
            progressBar.fillAmount = playerGO.transform.position.x / maxDistance;
        }

        else if(progressBar.fillAmount == 1)
        {
            player.goFoward = false; //stop moving once bar full 
        }
        
    }
}
