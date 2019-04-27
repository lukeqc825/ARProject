using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycasting_test : MonoBehaviour
{
    public Animator anim;
    Ray ray;
    string targetName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position); //This is our point to ray
        RaycastHit Hit;

        if (Physics.Raycast(ray, out Hit ))
        {
            targetName = Hit.transform.name.ToString();
            if (targetName == "c1" && anim.GetCurrentAnimatorStateInfo(0).IsName("none"))
            {
                anim.Play("frontToBack1");
            }
            else if (targetName == "c1" && anim.GetCurrentAnimatorStateInfo(0).IsName("frontToBack1"))
            {
                anim.Play("backToFront1");
            }
            else if (targetName == "c1" && anim.GetCurrentAnimatorStateInfo(0).IsName("backToFront1"))
            {
                anim.Play("frontToBack1");
            }
            if (targetName == "c2" && anim.GetCurrentAnimatorStateInfo(0).IsName("none"))
            {
                anim.Play("frontToBack2");
            }
            else if (targetName == "c2" && anim.GetCurrentAnimatorStateInfo(0).IsName("frontToBack2"))
            {
                anim.Play("backToFront2");
            }
            else if (targetName == "c2" && anim.GetCurrentAnimatorStateInfo(0).IsName("backToFront2"))
            {
                anim.Play("frontToBack2");
            }
            if (targetName == "c3" && anim.GetCurrentAnimatorStateInfo(0).IsName("none"))
            {
                anim.Play("frontToBack3");
            }
            else if (targetName == "c3" && anim.GetCurrentAnimatorStateInfo(0).IsName("frontToBack3"))
            {
                anim.Play("backToFront3");
            }
            else if (targetName == "c3" && anim.GetCurrentAnimatorStateInfo(0).IsName("backToFront3"))
            {
                anim.Play("frontToBack3");
            }

            /*switch (targetName)
                {
                    case "c1":
                        Debug.Log("We hit box one");
                        anim.Play("default1");
                        break;
                    case "c2":
                        Debug.Log("We hit box two");
                        anim.Play("default2");
                        break;
                    case "c3":
                        Debug.Log("We hit box three");
                        anim.Play("default3");
                        break;

                }*/


        }
        
    }
}
