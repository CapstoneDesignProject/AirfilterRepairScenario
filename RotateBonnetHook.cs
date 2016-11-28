using UnityEngine;
using System.Collections;

public class RotateBonnetHook : MonoBehaviour {
        public int cnt;
        public bool handConnect;
        private Vector3 v;
        private Vector3 bonnetHookVector;
	private Quanternion bonnetHookQuaternion;
	private Quaternion q;
	private Rotate bonnetRotate;
	
	// Use this for initialization
	void Start () {
        cnt = 0;
            handConnect = false;
            bonnetHookVector = new Vector3(8006.2f, -13301.95f, 23068.6f); 
            bonnetHookRotate = new Rotate(0, -70.0f);
	    bonnetHookQuaternion = new Quaternion(0.0f, 0.0f, 290.0f,0.0f); 	
	}
	// Update is called once per frame
	void Update () {
        
            v = transform.position;
            q = transform.rotation;
        
            if (handConnect)
            { 
               if (cnt == 0)
               {
                    v = bonnetHookVector;
		    q = bonnetHookQuaternion;
		    cnt++;
                    
		    this.GetComponent<Rigidbody>().isKinematic = false;
		    GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
		    BonnetUp bonnetUp = GameObject.Find("Bonnet").GetComponent<BonnetUp>();
		    bonnetUp.Bonnetup();
                    GameObject boxcoll = GameObject.Find("HandController");
		    BoxCollider bCollider = boxcoll.GetComponent<BoxCollider>();
 		    bCollider.gameObject.SetActive(false);
               }
            }
       }
	
       void OnTriggerEnter(Collider other)
       {
           if (other.transform.tag == "hand")
           {
                handConnect = true;
            }
       }
}


