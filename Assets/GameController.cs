using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameController : MonoBehaviour
{
    //VARIABLE DECLARATION
    private int randomNumber;
    private int clickCounter;
  
   
    void Start()
    {
        randomNumber = Random.Range(1, 11); //range 1-10 --> creating a random number
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0)) //si C-L se crida sa funció AddOneToCounter
        {
            AddOneToCounter();
        }

        if (Input.GetKeyDown(KeyCode.Return)) //si ENTER se crida sa funció 
        {
            if (HaveIWon()) //si has guanyat te alaba
            {
                Debug.Log($"YOU ARE A GENIOUS!!");
            }
        }
    }

    private void AddOneToCounter()
    {
        clickCounter++; //adding one at the variable clickCounter
        transform.localScale += Vector3.one;
    } 
    private bool HaveIWon()
    {
        if (clickCounter > randomNumber) //NOT ENOUGH CLICK
        {
            Debug.Log($"You have lost, because you've done more clicks ({clickCounter}) than the random number was {randomNumber}.");
            Destroy(gameObject); //quan li doni a s'enter i m'hagui passat de clicks, desapareixarà
            return false; //If I get here, the rest of sunction is not going to execut and the function will return false
        }
        else if(clickCounter == randomNumber) //equals CLICK
        {
            Debug.Log($"CONGRATULATIONS, YOU HAVE GUESSED THE AMOUNT OF CLICKS!!!");
            return true;
        }
        else //clickCounter > randomNumber MORE CLICKS
        {
            Debug.Log($"You have lost, because you haven't done enough clicks (random number={randomNumber} and your clicks={clickCounter}).");
            Destroy(gameObject); //quan li doni a s'enter i m'hagui passat de clicks, desapareixarà
            return false;
        }
    }

}
