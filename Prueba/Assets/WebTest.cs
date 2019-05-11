using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebTest : MonoBehaviour {

	// Use this for initialization
	IEnumerator Start () {
        WWW request = new WWW("http://192.168.0.244/sqlconnect/webtest.php");
        yield return request;
        string[] webResults = request.text.Split('\t');
        Debug.Log(webResults[0]);
        int webNumber = int.Parse(webResults[1]);
        webNumber *= 2;
        Debug.Log(webNumber);
	}
}
