using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackController : MonoBehaviour
{
    private List<GameObject> cubeList;
    [SerializeField] private GameObject cubePrefab;
    [SerializeField] private GameObject firstCube, secondCube;
    [SerializeField] private GameObject cubesParent;

    private void Start() {
        cubeList = new List<GameObject>();
        cubeList.Add(firstCube);
        cubeList.Add(secondCube);
    }


    public void AddCube(){
        foreach(GameObject cube in cubeList)
        {
            cube.transform.position += Vector3.up * GameManager.Instance.cubeWidth;
        }

        GameManager.Instance.player.transform.GetChild(1).transform.position += Vector3.up * GameManager.Instance.cubeWidth;
        GameManager.Instance.player.transform.position += Vector3.up * GameManager.Instance.cubeWidth;

        GameObject createdCube = Instantiate(cubePrefab, new Vector3(cubeList[cubeList.Count - 1].transform.position.x, cubeList[cubeList.Count - 1].transform.position.y - GameManager.Instance.cubeWidth, cubeList[cubeList.Count - 1].transform.position.z), Quaternion.identity);

        createdCube.transform.parent = cubesParent.transform;

        cubeList.Add(createdCube);

    }



    public void RemoveCube(GameObject _cube)
    {
        cubeList.Remove(_cube);
        _cube.transform.parent = null;
        // GameManager.Instance.player.transform.GetChild(1).transform.position -= Vector3.up * GameManager.Instance.cubeWidth;
        // GameManager.Instance.player.transform.position -= Vector3.up * GameManager.Instance.cubeWidth;
        // Destroy(_cube);
    }
}
