using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject bfr;
    public GameObject aft;
    bool change = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(change == false)
        {
            bfr.SetActive(true);
            aft.SetActive(false);
        }

        else
        {
            aft.SetActive(true);
            bfr.SetActive(false);
        }
    }

    public void ChangePic()
    {
        change = !change;
    }
}
