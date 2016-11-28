using UnityEngine;
using System.Collections;
#define MAX_CNT 20


public class BonnetDown : MonoBehaviour {
    public int cntDown, cntUp;
    public bool flag;

    filterchange permission;
    BonnetUp bonnet;
    Vector3  bonnetPosition;	
    Vector3  bonnetOpenRotation;
    Vector3  bonnetCloseRoatation;
	
    // Use this for initialization
    void Start () {
        cntUp = 0;
        cntDown = 0;
        flag = true;	
        
	permission = GameObject.Find("airfiltertop").GetComponent<FilterChange>();     
	bonnet = GameObject.Find("Bonnet").GetComponent<BonnetUp>();
	bonnetPosition = new Vector3(0, -0.2f, 0);
	bonnetOpenRotation = new Vector3(2.0f, 0, 0);
	bonnetCloseRotation = new Vector3(-2.0f, 0, 0);
    }
    
    public void bonnetDown()
    {
	    if(!permission.bonnetpermit)
		    return;
        
            if (cntUp < MAX_CNT)
            {
                transform.Rotate(bonnetOpenRotation);
                cntUp++;
            }
            if (cntUp == MAX_CNT && flag)
            {
               bonnet.transform.Translate(bonnetClosePosition);
               flag = false;
            }
        
    }
	
    public void bonnetUp()
    {
        if (cntDown < MAX_CNT)
        {
            transform.Rotate(bonnetCloseRotation);
            cntDown++;
        }
    }
}
