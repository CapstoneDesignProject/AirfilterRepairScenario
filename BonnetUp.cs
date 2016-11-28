using UnityEngine;
using System.Collections;

public class BonnetUp : MonoBehaviour
{
    public bool bonnetUp = false;
    public void Bonnetup()
    {
        transform.Translate(new Vector3(0, 0.2f, 0));
        bonnetUp = true;
    }
}
