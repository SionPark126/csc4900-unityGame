using UnityEngine;
using System.Collections;

public class CameraFollowScript : MonoBehaviour 
{
	[SerializeField]
	GameObject PlayerCar;
	bool Follow;

	[SerializeField]
	float OffSetX =2;
	[SerializeField]
	float OffSetY =2;

	void Start () 
	{
		Follow = true;
	}

	void FixedUpdate () 
	{
		if(Follow)
		transform.position = new Vector3 (PlayerCar.transform.position.x + OffSetX, PlayerCar.transform.position.y + OffSetY, -10.0f);	
	}
}
