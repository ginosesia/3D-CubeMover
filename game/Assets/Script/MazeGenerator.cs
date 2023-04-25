using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeGenerator : MonoBehaviour
{
    public GameObject cube;
    public GameObject edgeCube;
    public int mazeSize = 20;

    public int minMazeValue = 0;
    public int maxMazeValue;

    public GameObject[,] maze;


    // Start is called before the first frame update
    void Start()
    {


        maze = new GameObject[mazeSize, mazeSize];
        GenerateMaze(mazeSize);

        maxMazeValue = mazeSize;
    }


    public void GenerateMaze(int size)
    {
        for(int x = 0; x < size; x++) 
        {
            for (int z = 0; z < size; z++)
            {
                maze[x, z] = Instantiate(GetCube(x,z), new Vector3(x, 0, z), Quaternion.identity);
            }

        }
    }


    private GameObject GetCube(int x, int z)
    {
        if (x == minMazeValue || x == maxMazeValue) return edgeCube;
        if (z == minMazeValue || z == maxMazeValue) return edgeCube;

        return cube;
    }

}
