using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatrixManager : MonoBehaviour
{

    public GameObject vertexCube;
    public GameObject faceCube;
    public Transform matrixHolder;

    public int sizeX;
    public int sizeY;
    public int sizeZ;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void generateMatrix()
    {
        for (int x = 0; x < sizeX; x++)
        {
            for(int y = 0; y < sizeY; y ++)
            {
                for(int z = 0; z < sizeZ; z++)
                {
                    Vector3 currCoords = new Vector3(x * 2, y * 2, z * 2);
                    if ((x + y + z) % 2 == 0)
                    {
                        Instantiate(faceCube, currCoords, Quaternion.identity, matrixHolder);
                    }
                    else
                    {
                        Instantiate(vertexCube, currCoords, Quaternion.identity, matrixHolder);
                    }
                }
            }
        }
    }

    public void razCubes()
    {
        foreach(Transform cube in matrixHolder)
        {
            Destroy(cube.gameObject);
        }
    }
}
