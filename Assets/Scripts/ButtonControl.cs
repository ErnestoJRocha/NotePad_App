using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonControl : MonoBehaviour
{
    public GameObject theText;
    public AudioSource clearSound;
    public GameObject thePanel;


    public void ClearText()
    {
        theText.GetComponent<InputField>().text = "";
        clearSound.Play();
    }

    public void cancelButton()
    {
        thePanel.SetActive(false);
    }

    public void closeButton()
    {
        thePanel.SetActive(true);
    }

    public void QuitButton()
    {
       Application.Quit();
    }


}
