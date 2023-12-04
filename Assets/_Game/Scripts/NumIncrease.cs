using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumIncrease : MonoBehaviour
{
    public TextMeshProUGUI myLabel;
    private int number;

    void Start()
    {
        number = 0;
        print("In Start ");
    }
    public void IncreaseButton()
    {
        number = number + 1;
        myLabel.GetComponent<TextMeshProUGUI>().text = "Count" + number;
    }
    public void DecreaseButton()
    {
        number = number - 1;
        myLabel.GetComponent<TextMeshProUGUI>().text = "Count" + number;
    }
}
