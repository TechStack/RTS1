using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {


  public  Transform target;
    public int rotationSpeed;
    public Rigidbody rigidBody;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(target.position - transform.position), rotationSpeed * Time.deltaTime)           ;

        rigidBody.AddForce(transform.forward, ForceMode.Impulse);

        //transform.position += transform.forward * 2 * Time.deltaTime;

    }
}
