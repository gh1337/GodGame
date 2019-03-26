using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIController : MonoBehaviour {

    public Button B_InvokeCube;
    public Button B_PlacementModeTrue;
    public GameObject cube;

    public void B_InvokeCubeOnClick()
    {
        Instantiate(cube, new Vector3(1, 1, 1), Quaternion.identity);
    }

    public void B_PlacementModeTrueOnClick()
    {
        if (BlockPlacer.isPlacementMode == true){
            BlockPlacer.isPlacementMode = false;
        }
        else
        {
            BlockPlacer.isPlacementMode = true;
        }
    }

}
