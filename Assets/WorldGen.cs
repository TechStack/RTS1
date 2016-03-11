using UnityEngine;
using System.Collections;

public class WorldGen : MonoBehaviour {


    public Transform Block;
    public Transform offset;

    // Use this for initialization
    void Start () {
        //float x, y, z;
        //x = 1;
        //z = 1;
        //y = 0;
        //for (x = 1; x < 100; x++)
        //{
        //    for (z = 1; z < 100; z++)
        //    {
        //        var go = Instantiate(Block, new Vector3(x, y, z), transform.rotation);
        //        y = y + .01f;
        //    }
        //}


    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(1))
        {
            Vector3 v3 = Input.mousePosition;
            //v3.z = 10;
            //v3 = Camera.main.ScreenToWorldPoint(v3);
            Ray ray = Camera.main.ScreenPointToRay(v3);
            RaycastHit hit;
            Physics.Raycast(ray, out hit);

            var go = Instantiate(Block, hit.point, transform.rotation);
            Debug.Log("Mouse 1 Click:" + Input.mousePosition);
                }
}
}
