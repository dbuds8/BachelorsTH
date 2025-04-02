using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    // Start is called before the first frame update
    public Text displayText;

    private string currentInput = "";
    private float firstNumber = 0f;
    private float secondNumber = 0f;
    private string currentOperation = "";

    void Start()
    {
        displayText.text = "0";
        
    }

    public void OnButtonClick(string number)
    {
        currentInput += number;
        displayText.text = currentInput;
    }

    public void OnOperationButtonClick(string operation)
    {
        if (currentInput != "")
        { 
            firstNumber = float.Parse(currentInput);
            currentInput = "";
        }
        currentOperation = operation;
    
    }

    public void OnEqualsButtonClick()
    {
        if (currentInput != "")
        { 
            secondNumber = float.Parse(currentInput);
            float result = 0f;

            switch (currentOperation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    if (secondNumber != 0)
                        result = firstNumber / secondNumber;
                    else
                        result = 0;
                    break;
            }

            displayText.text = result.ToString();
            currentInput = result.ToString() ;
            currentOperation = "";
            firstNumber = 0f;
            secondNumber = 0f;
        }
    }

    public void OnClearButtonClick()
    {
        currentInput = "";
        displayText.text = "0";
    }

}
