using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ClickHandler : MonoBehaviour {

	// Use this for initialization
    void Start()
    {

        string str = Application.dataPath;
        Debug.Log("0000000");
        Debug.Log(str);
        List<string> btnsName = new List<string>();
        btnsName.Add("BtnPay");
        btnsName.Add("BtnQuit");
        btnsName.Add("BtnQuary");



        foreach (string btnName in btnsName)
        {
            GameObject btnObj = GameObject.Find(btnName);
            Button btn = btnObj.GetComponent<Button>();
            EventTriggerListener.Get(btn.gameObject).onClick = OnClick;
            //             btn.onClick.AddListener(delegate()
            //             {
            //                 this.OnClick(btnObj);
            //             });

            //             UIEventListener btnListener = btn.gameObject.AddComponent<UIEventListener>();  
            //             btnListener.OnClick += delegate(GameObject gb)
            //             {
            //                  Debug.Log(gb.name);
            //             };
            //             btnListener.OnMouseEnter += delegate(GameObject gb)
            //             {
            //                 Debug.Log(gb.name);
            //             };
            //             btnListener.OnMouseExit += delegate(GameObject gb)
            //             {
            //                  Debug.Log(gb.name);
            //             } 
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnClick(GameObject sender)
    {
        AndroidJavaObject jo;
        switch (sender.name)
        {
            case "BtnPay":
                Debug.Log("Button BtnPay. ClickHandler.");
                jo = new AndroidJavaObject("unity2android.wesai.com.communication.Utils");
                jo.Call("doPay");
                break;
            case "BtnQuit":
                Debug.Log("Button BtnQuit. ClickHandler.");
                Application.Quit();
                break;
            case "BtnQuary":
                Debug.Log("Button BtnQuary. ClickHandler.");
                jo = new AndroidJavaObject("unity2android.wesai.com.communication.Utils");
                jo.Call("doQueryUserInfo");
                break;
        }
       
    }
}
