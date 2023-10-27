using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Switch : MonoBehaviour
{
    public GameObject ThirdPerson;
    public GameObject FirstPerson;
    public int Manager;

    public void ChangeCamera(){
        GetComponent<Animator>().SetTrigger("Change");
    }
    public void ManageCamera(){
        if(Manager == 0)
        {
            fcam();
            Manager = 1;
        }
        else{
            tcam();
            Manager = 0;
        }
    }

    void tcam()
    {
        ThirdPerson.SetActive(true);
        FirstPerson.SetActive(false);
    }

    void fcam()
    {
        ThirdPerson.SetActive(false);
        FirstPerson.SetActive(true);
    }
}
