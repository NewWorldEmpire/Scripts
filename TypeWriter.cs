using UnityEngine;
using System.Collections;

public class TypeWriter : MonoBehaviour
{
	private const float WAIT_TIME = 0.00001f;
	
	private float waitTimer = 0.0f;
	public string wholeText = "";
	public string otherText = "";
	private string typewriterText = "";
	private int currentIndex = 0;

	private bool clickActivation = false;


	private bool cheese = false;




	void Start(){
		wholeText = "Still Pulling From TypeWriter";
	}


	void Update ()
	{
		if (Input.GetKey (KeyCode.Mouse0)) { 
			clickActivation = true;
			cheese = false;
		}

		if (clickActivation)
		{
			//if (Input.GetMouseButton (LEFT_MOUSE_BUTTON))
			waitTimer += Time.deltaTime;
			wholeText = GameObject.Find ("Basic").GetComponent<TriggerWriting> ().wholeText;
			
			if (waitTimer > WAIT_TIME && currentIndex < wholeText.Length) {            
				typewriterText += wholeText [currentIndex];
				waitTimer = 0.0f;
				++currentIndex;
			}

			if (currentIndex == wholeText.Length)
			{
				clickActivation = false;
				currentIndex = 0;
				cheese = true;

			}

		}
	}
	
	void OnGUI()
	{
		if (cheese) 
		{
			otherText = typewriterText;
			if (Input.GetMouseButton(0))
			{

			typewriterText = "";
			}
			GUI.TextArea (new Rect (0.0f, 0.0f, Screen.width, Screen.height / 3), otherText);
		}
		else
		{
			GUI.TextArea (new Rect (0.0f, 0.0f, Screen.width, Screen.height / 3), typewriterText);
		}
	}
}