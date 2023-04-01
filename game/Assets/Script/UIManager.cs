using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI moveCountLabel;

    // Update is called once per frame
    void Update()
    {
        moveCountLabel.text = $"Move Count: {Global.moveCount}";
    }
}
