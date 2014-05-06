using UnityEngine;
using System.Collections;

public class CameraSwitch : MonoBehaviour {

	public Camera cam1  ;//assign your main camera here
	public Camera cam2  ;//assign your top camera here
	public Camera cam3  ;
	public Camera cam4  ;
	
	void Start()
	{
		cam1.enabled = true;//a the start of the game main camera will be enabled
		cam2.enabled = false;
		cam3.enabled = false;
		cam4.enabled = false;
	}
	
	void OnGUI ()
	{
		
	}
	
	
	void OnTriggerEnter(Collider other)
	{

		if (other.gameObject.name == "MotherSensor" && (cam1.enabled == true)) {
			cam1.enabled = false;
			cam2.enabled = true;
			cam3.enabled = false;
			cam4.enabled = false;
		}
		else if (other.gameObject.name == "MotherSensor" && (cam2.enabled == true)) {
			cam1.enabled = false;
			cam2.enabled = false;
			cam3.enabled = true;
			cam4.enabled = false;
		}
		else if (other.gameObject.name == "MotherSensor" && (cam3.enabled == true)) {
			cam1.enabled = false;
			cam2.enabled = false;
			cam3.enabled = false;
			cam4.enabled = true;
		}
		else if (other.gameObject.name == "MotherSensor" && (cam4.enabled == true)) {
			cam1.enabled = true;
			cam2.enabled = false;
			cam3.enabled = false;
			cam4.enabled = false;
		}
	}//trigger on enter
}