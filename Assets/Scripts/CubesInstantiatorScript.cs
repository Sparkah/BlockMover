using System;
using System.Collections;
using TMPro;
using UnityEngine;

public class CubesInstantiatorScript : MonoBehaviour
{
    [SerializeField] GameObject cubePrefab;
    [SerializeField] TMP_InputField cubeMoveDistance;
    [SerializeField] TMP_InputField cubeSpeed;
    [SerializeField] TMP_InputField cubeTimeToInstantiate;

    private int cubeMoveDistanceInt=10;
    private int cubeSpeedInt =1;
    private int cubeTimeToInstantiateInt=1;

    void Start()
    {
        StartCoroutine(InstantiateCube());
    }

    public void SetCubeSpeed()
    {
        Int32.TryParse(cubeSpeed.text, out cubeSpeedInt);
    }

    public void SetCubeMoveDistance()
    {
        Int32.TryParse(cubeMoveDistance.text, out cubeMoveDistanceInt);
    }

    public void SetCubeTimeToInstantiate()
    {
        Int32.TryParse(cubeTimeToInstantiate.text, out cubeTimeToInstantiateInt);
    }

    IEnumerator InstantiateCube()
    {
        yield return new WaitForSeconds(cubeTimeToInstantiateInt);
        GameObject cube = Instantiate(cubePrefab, new Vector3(0,0.5f,0), Quaternion.identity);
        cube.GetComponent<CubeScript>().SetCubeParams(cubeMoveDistanceInt, cubeSpeedInt);
        StartCoroutine(InstantiateCube());
    }
}