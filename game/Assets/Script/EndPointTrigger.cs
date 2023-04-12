using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPointTrigger : MonoBehaviour
{

    private UIManager UIManager;

    private void Start()
    {
        UIManager = FindObjectOfType<UIManager>();
    }

    private void OnTriggerEnter(Collider other)
    {

        UIManager.LevelComplete();

    }

}
