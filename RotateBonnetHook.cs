using UnityEngine;
using System.Collections;

public class RotateBonnetHook : MonoBehaviour {
    public int cnt = 0;
    public bool handconnect=false;
   
	// Use this for initialization
	void Start () {
	
     
	}
	// Update is called once per frame
	void Update () {
        Vector3 v;//Vector3 변수를 선언  
        Quaternion c;
         v = transform.position;
         c = transform.rotation;
        
         if (handconnect)
         { 
            if (cnt == 0)
            {
              
                v.x = 8006.2f;//원하는 값을 입력
                v.y = -13301.95f;
                v.z = 23068.6f;
                c.x = 0.0f;
                c.y = 0.0f;
                c.z = 290.0f;
                cnt++;
           
                this.transform.Rotate(0, 0, -70.0f);
                GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
                BonnetUp bu = GameObject.Find("Bonnet").GetComponent<BonnetUp>();
                this.GetComponent<Rigidbody>().isKinematic = false;
                bu.Bonnetup();
                GameObject boxcoll = GameObject.Find("HandController");
                BoxCollider bc = boxcoll.GetComponent<BoxCollider>();
                Destroy(bc); 
            }
         }
    }
	
    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "hand")
        {
            handconnect = true;
            
        }

    }
}


