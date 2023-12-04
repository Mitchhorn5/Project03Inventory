using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumDecrease : MonoBehaviour
{
    public TextMeshProUGUI myLabel;
    private int number;

    void Start()
    {
        number = 0;
        print("In Start ");
    }

    public void DecreaseButton()
    {
        Debug.Log("was pressed");
        number = number - 1;
        myLabel.GetComponent<TextMeshProUGUI>().text = "Count" + number;
    }
}
