using UnityEngine;
using System.Collections;

public class filterChange : MonoBehaviour
{
    public bool connect;
    public bool bonnetpermit;
	Vec filterPosition;

	filterchange newFilter;
	BonnetUp bonnetUp;

	Vector3 filterNewPosition;
	Vector3 filterNewRotation;

    void Start()
    {
		v = transform.localPosition;
		connect = false;
		bonnetpermit = false;

		newFilter = GameObject.Find("newfilter").GetComponent<filterchange>();
		bonnetUp = GameObject.Find("Bonnet").GetComponent<BonnetUp>();

		filterNewPosition = new vector3 (-9.578f, 2.184f, -99.127f);
		filterNewRotation = new vector3 (0.4816588f, 359.7331f, 0.6789147f);

    }

    void Update()
    {
       
    
        if (newFilter.connect == true)
        {
            if ((transform.localPosition.x >= -10.0f && transform.localPosition.x <= -8.0f) && (transform.localPosition.y >= 1.0f && transform.localPosition.y <= 3.0f) && (transform.localPosition.z >= -100.0f && transform.localPosition.z <= -98.0f))
            {
                connect = true;
            }

            if (connect == true)
            {
				transform.localPosition = filterNewPosition;
				transform.rotation = Quaternion.Euler(filterNewRotation);
                GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
                bonnetpermit = true;
                bonnetUp.bnu = false;
            }
        }
    }
}
