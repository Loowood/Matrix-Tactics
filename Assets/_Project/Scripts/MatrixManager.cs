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

    List<List<List<GameObject>>> matrix;

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
        matrix = new List<List<List<GameObject>>>();
        for (int x = 0; x < sizeX; x++)
        {
            matrix.Add(new List<List<GameObject>>());
            for(int y = 0; y < sizeY; y ++)
            {
                matrix[x].Add(new List<GameObject>());
                for(int z = 0; z < sizeZ; z++)
                {
                    Vector3 currCoords = new Vector3(x * 2, y * 2, z * 2);
                    if ((x + y + z) % 2 == 0)
                    {
                        matrix[x][y].Add(CreateCubes(faceCube, currCoords, matrixHolder, x, y, z));
                    }
                    else
                    {
                        matrix[x][y].Add(CreateCubes(vertexCube, currCoords, matrixHolder, x, y, z));
                    }
                }
            }
        }
    }

    public void razCubes()
    {
        /*
        foreach(Transform cube in matrixHolder)
        {
            Destroy(cube.gameObject);
        }
        */
        deleteCube(0,0,0);
    }

    private GameObject CreateCubes(GameObject cubePrefab, Vector3 coords, Transform matrixHolder, int x, int y, int z){
        GameObject result = Instantiate(cubePrefab, coords, Quaternion.identity, matrixHolder);
        CubeState cubeState = result.GetComponent<CubeState>();
        if(cubeState != null){
            cubeState.setcoordonates(x, y, z);
        }
        return result;
    }

    public void deleteCube(int x, int y, int z){
        GameObject cube = matrix[x][y][z];
        if(cube != null){
            matrix[x][y][z] = null;
            Destroy(cube);
        }
    }
}
