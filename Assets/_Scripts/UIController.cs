using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour {

    private Button btnPay;
	// Use this for initialization
	void Start () {
        //btnPay = GetComponent<Button>();
        //btnPay.onClick.AddListener(OnClick); 
        //btnPay.onClick.AddListener(OnClick);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnClick()
    {
        Debug.Log("click this 1");
    }

    public void click()
    {
        Debug.Log("click this 2");
    }
}
