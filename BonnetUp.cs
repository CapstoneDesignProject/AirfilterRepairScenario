using UnityEngine;
using System.Collections;

public class BonnetUp : MonoBehaviour {
    public bool bonnetUp = false;
	// Use this for initialization
	void Start () {
	
	}
	 public void Bonnetup()
    {
        transform.Translate(new Vector3(0, 0.2f, 0));
        bonnetUp = true;
    }
	// Update is called once per frame
	void Update () {
	
	}
}
