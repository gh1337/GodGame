using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIController : MonoBehaviour {

    public Button B_InvokeCube;
    public GameObject cube;

    public void B_InvokeCubeOnClick()
    {
        Instantiate(cube, new Vector3(1, 1, 1), Quaternion.identity);
    }

}
