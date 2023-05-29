
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using TMPro;
public class ExtractCrusher : MonoBehaviour
{
    public List<Button> buttons; //List of buttons
    public List<Button> shuffledButtons; //List of shuffled buttons
    int counter = 0; //tracks how many buttons pressed in sequence
    public GameObject gamePanel;
    
    public void Start()
    {
        
        RestartGame();
    }
    public void RestartGame()
    {
        counter = 0;
        shuffledButtons = buttons.OrderBy(a => Random.Range(0, 100)).ToList(); //shuffle buttons with seeds 0-100
        for (int i = 1; i < 11; i++)
        {
            shuffledButtons[i - 1].GetComponentInChildren<TextMeshProUGUI>().text = i.ToString(); //Set text on buttons to correct number
            shuffledButtons[i - 1].interactable = true;
            shuffledButtons[i - 1].image.color = new Color32(177, 220, 233, 255); //Initial color
        }
    }
    public void PressButton(Button button) //Function for buttons to call on click
    {
        if (int.Parse(button.GetComponentInChildren<TextMeshProUGUI>().text) - 1 == counter) //Check if number of buttons -1 is equal to counter, to know the button is pressed
        {
            counter++;
           
            button.interactable = false;
            button.image.color = Color.green;
            if (counter == 10) //Check if all buttons are already pressed
            {
                RestartGame();
                
                //gamePanel.SetActive(false);
            }
        }
    }

    //coroutine for closing 
}