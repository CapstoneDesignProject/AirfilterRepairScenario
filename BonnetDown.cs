using UnityEngine;
using System.Collections;

public class BonnetDown : MonoBehaviour {
    public int cnt, cnt2;
    public bool;

   
    // Use this for initialization
    void Start () {
        cnt = 0;
        cnt2 = 0;
        a = true;	
    }
    
    public void Bonnetdown()
    {
        filterchange2 permission = GameObject.Find("airfiltertop").GetComponent<filterchange2>();
        BonnetUp bon = GameObject.Find("Bonnet").GetComponent<BonnetUp>();
        if (permission.bonnetpermit)
        {
            if (cnt2 < 20)
            {
                transform.Rotate(2.0f, 0, 0);
                cnt2++;
            }
            if (cnt2 ==20&&a)
            {
               bon.transform.Translate(new Vector3(0, -0.2f, 0));
               a = false;
            }
        }
    }
	
    public void bonnetDown()
    {
        if (cnt < 20)
        {
            transform.Rotate(-2.0f, 0, 0);
            cnt++;
        }
    }
}
