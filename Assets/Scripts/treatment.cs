using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treatment : MonoBehaviour
{

    public GameObject target;
    public RuntimeAnimatorController anim2;

    public void changeAnimator()
    {
        //clicaram em mim
        Debug.Log("clicaram em mim");
        target.GetComponent<Animator>().runtimeAnimatorController = anim2;
    }


}
