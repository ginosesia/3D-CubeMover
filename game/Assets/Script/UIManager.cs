using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI moveCountLabel;
    [SerializeField] private TextMeshProUGUI moveCountLevelCompleteLabel;
    [SerializeField] private GameObject levelCompletePanel;

    // Update is called once per frame
    void Update()
    {
        moveCountLabel.text = $"Move Count: {Global.moveCount}";
    }



    public void LevelComplete()
    {
        moveCountLevelCompleteLabel.text = $"Level Completed in {Global.moveCount} moves!";
        levelCompletePanel.SetActive(true);

    }



}
