using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectVariables : MonoBehaviour {

    //Object world properties
    public bool isSolid;
    public int objType; // 0 = block, 1 = building, 2 = entity
    public int objID; // See OBJ ID list in documentation
    public bool isDestructable; // can the object be destroyed?

    //Object identifier properties
    public string objName; //name of object
    public string objDesc; //object description

    //Object statistical properties
    public int objHealth; //Health of object. Applies to Mobs and plants


    public int objAttack; //Attack ability of object. Applies to mobs which can attack
    public int objMobEggSpawnablePercent; //Chance per cycle to spawn an egg

    //
    public float objTimeExistance; //Time it has existed
    public float objTimeTillDeath; //Time until it dies



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
