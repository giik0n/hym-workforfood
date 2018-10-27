using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObjectsToCollect : MonoBehaviour {
  public static int objects = 0;

    List<Vector3> axises;

    // Use this for initialization
    void Awake () {
    objects++;
  }

    void Start()
    {
    	//if(objects > -1) return;
        axises = new List<Vector3>();
        axises.Add(new Vector3(14, 131, -208));
        axises.Add(new Vector3(14, 132, -209));
        axises.Add(new Vector3(14, 133, -210));
        axises.Add(new Vector3(14, 134, -211));
        axises.Add(new Vector3(14, 135, -212));
    		axises.Add(new Vector3(9,  132,  -196));
    		axises.Add(new Vector3(17, 132, -175));
    		axises.Add(new Vector3(22, 137, -173));
    		axises.Add(new Vector3(6, 137, -167));
    		axises.Add(new Vector3(-6, 134, -154));
    		axises.Add(new Vector3(9, 126, -139));
    		axises.Add(new Vector3(3, 128, -155));
    		axises.Add(new Vector3(15, 126, -155));
    		axises.Add(new Vector3(20, 126, -165));
    		axises.Add(new Vector3(25, 126, -158));
    		axises.Add(new Vector3(32, 126, -144));
    		axises.Add(new Vector3(-2, 131, -218));
    		axises.Add(new Vector3(-24, 131, -210));
    		axises.Add(new Vector3(-26, 137, -205));
    		axises.Add(new Vector3(-37, 137, -220));
    		axises.Add(new Vector3(-47, 133, -232));
    		axises.Add(new Vector3(-60, 126, -217));
    		axises.Add(new Vector3(-45, 126, -224));
    		axises.Add(new Vector3(-60, 126, -206));
    		axises.Add(new Vector3(-40, 126, -206));
    		axises.Add(new Vector3(-56, 126 -190));
    		axises.Add(new Vector3(8, 132, -220));
    		axises.Add(new Vector3(17, 131, -229));
    		axises.Add(new Vector3(9, 132, -250));
    		axises.Add(new Vector3(4, 137, -252));
    		axises.Add(new Vector3(31, 133, -273));
    		axises.Add(new Vector3(9, 126, -271));
    		axises.Add(new Vector3(5, 126, -287));
    		axises.Add(new Vector3(-11, 126, -282));
    		axises.Add(new Vector3(16, 126, -287));
    		axises.Add(new Vector3(20, 132, -208));
    		axises.Add(new Vector3(30, 132, -209));
    		axises.Add(new Vector3(51, 132, -216));
    		axises.Add(new Vector3(53, 137, -222));
    		axises.Add(new Vector3(58, 137, -206));
    		axises.Add(new Vector3(72, 133, -194));
    		axises.Add(new Vector3(86, 126, -209));
    		axises.Add(new Vector3(72, 126, -218));
    		axises.Add(new Vector3(85, 126 -225));
    		axises.Add(new Vector3(69, 126 -234));
    		axises.Add(new Vector3(91, 126, -235));

        int COUNT = 12;
        //Random rnd = new Random();

        do {
          int index = rnd.next(axises.Count);
          Vector3 vec = axises[index];

          axises.Remove(vec);

          COUNT--;
        } while(COUNT > 0);


        GameObject[] arrayofcubes = GameObject.FindGameObjectsWithTag("Enemy");

        for (int i = 0; i < objects; i++)
        {
            var index = Random.Range(0, axises.Count - 1);
            var CubeAxis = axises[index];
            axises.RemoveAt(index);
            arrayofcubes[i].transform.position = CubeAxis;
        }
    }

        void OnTriggerEnter (Collider plyr) {
    if( objects > -1 && plyr.gameObject.tag == "Player"){
      objects--;
      gameObject.SetActive(false);
    }

  }
}
