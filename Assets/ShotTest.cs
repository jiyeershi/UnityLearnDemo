using UnityEngine;
using System.Collections;

public class ShotTest : MonoBehaviour {

    public string file = "";
    Texture2D t;
    private void Awake()
    {
        file = Application.persistentDataPath + "/Shot/";
    }
    private void OnGUI()
    {
        GUI.Window(0, new Rect(0, 0, 400, 600), Window, "");
        if (t)
        {
            var content = new GUIContent("", t);
            GUI.Label(new Rect(400, 0, Screen.width / 2, Screen.height / 2), content);
        }
    }

    void Window(int id)
    {
        if (GUILayout.Button("Capture"))
        {
            StartCoroutine(Capture());
        }
        GUILayout.Space(100);
        if (GUILayout.Button("ReadPixel"))
        {
            StartCoroutine(ReadPixel());
        }
    }

    IEnumerator Capture()
    {
        yield return new WaitForEndOfFrame();
        Application.CaptureScreenshot(file + "capture");
    }

    IEnumerator ReadPixel()
    {
        yield return new WaitForEndOfFrame();
        t = new Texture2D(Screen.width, Screen.height);
        t.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
        t.Apply();
    }


}
