using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class test : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject m_gameobject = new GameObject("Image");
        m_gameobject.AddComponent<Image>();
        m_gameobject.transform.SetParent(GameObject.Find("Canvas").transform);
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
