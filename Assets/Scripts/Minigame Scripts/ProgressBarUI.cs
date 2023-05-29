using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBarUI : MonoBehaviour
{
    public int minimum;
    public int maximum;
    public int current;
    public Image mask;
    public Image fill;
    public Color color;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetCurrentFill();
    }

    void GetCurrentFill()
    {
        float currentOffset = current - minimum;
        float maxOffset = maximum - minimum;
        float fillAmount = currentOffset / maxOffset;
        mask.fillAmount = fillAmount;

        fill.color = color;
    }
}
