using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    [SerializeField] private GameObject levelCompletePanel;
    [SerializeField] private Transform[] levels;
    [SerializeField] private Transform levelSpawnerPosition;
    private Transform levelStartingPoint;
    private Transform cube;
    private Transform currentLevelTransform;

    // Start is called before the first frame update
    void Start()
    {
        cube = GameObject.Find("Cube").transform;

        Global.currentLevel = 0;
        currentLevelTransform = Instantiate(levels[Global.currentLevel], levelSpawnerPosition.position, Quaternion.identity);

        MoveCube(currentLevelTransform);

    }


    public void NextLevel()
    {
        //Destroy current level
        Destroy(currentLevelTransform.gameObject);

        Global.currentLevel++;
        var nextLevel = Instantiate(levels[Global.currentLevel], levelSpawnerPosition.position, Quaternion.identity);

        currentLevelTransform = nextLevel;

        MoveCube(currentLevelTransform);

        levelCompletePanel.SetActive(false);
        Global.moveCount = 0;
    }


    private void MoveCube(Transform level)
    {

        levelStartingPoint = level.Find("LevelStartingPoint").transform;

        cube.position = new Vector3(levelStartingPoint.position.x, cube.transform.position.y, levelStartingPoint.position.z);
    }


}
