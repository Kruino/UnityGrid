using UnityEngine;
using UnityEngine.UI;
using System.Collections;


	public class Buttons : MonoBehaviour
	{
		public Button yourButton;		
		public int buttonStartValue = 0;
	    public static int Value;
	    
	    



	void Start()
	{
		 
	}
    void Update()
    {
		if (Value < buttonStartValue || Value > buttonStartValue)
		{
			Button btn = yourButton.GetComponent<Button>();
			btn.onClick.AddListener(TaskButtonValue1);
		}
		if (Value == buttonStartValue)
		{
			Button btnR = yourButton.GetComponent<Button>();
			btnR.onClick.AddListener(ButtonValueReset);
		}

		

	
	}
	

    public void TaskButtonValue1()
		{
		Value = buttonStartValue;
		Text myText = GameObject.Find("Canvas/Text").GetComponent<Text>();
		myText.text = "Value = " + Value;
	}

		public void ButtonValueReset()
		{
		Value = 0;
		Text myText = GameObject.Find("Canvas/Text").GetComponent<Text>();
		myText.text = "Value = " + Value;
	}
	}

