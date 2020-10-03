using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Interactive : MonoBehaviour, I_Interactive
{
    public Text itemInfo;
    private bool interactedWith = false;
    private bool viewBuffer = false;
    public string educationalText1; //this is what the text will be set to when looking at this object
    public string educationalText2;
    public string educationalText3;

    public void Clicked()
    {
        throw new System.NotImplementedException();
    }

    public void LookedAt(string educationalInformation) //possible to set the text to something from the camera object if we want to
    {
        itemInfo.text = educationalText1+"\n"+ educationalText2+"\n"+ educationalText3; //setting the text

        viewBuffer = true; //a view buffer so that the text doesn't vanish for a second while looking at the object
        StartCoroutine(ExecuteAfterTime(2f)); //executes this function and the delay inside it is 2 seconds
    }

    IEnumerator ExecuteAfterTime(float time)
    {
        if (!interactedWith) //if not interacted with yet
        {
            do
            {
                interactedWith = true;

                viewBuffer = false; //sets view buffer to false. This will be set to true if camera is still looking at object

                yield return new WaitForSeconds(time); //waits for 2 seconds
                interactedWith = false; 
                if (!viewBuffer)//if viewbuffer is false it will clear the onscreen text
                    itemInfo.text = ""; //empty string because the text will go away after looking away from the object
            } while (viewBuffer);//if the viewbuffer is true, it will loop, keeping the current text on screen

        }

    }

    // Start is called before the first frame update
    void Start()
    {
        itemInfo.text = "";
    }

    // Update is called once per frame
    void Update()
    {
    }
}
