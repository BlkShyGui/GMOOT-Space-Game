using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogManager : MonoBehaviour
{
    public TextMeshProUGUI DialogText;
    public string[] Sentences;
    private int Index = 0;
    public float DialogSpeed;
    public GameObject continueButton;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WriteSentence());
    }

    // Update is called once per frame
    void Update()
    {
       if(DialogText.text == Sentences[Index])
        {
            continueButton.SetActive(true);
        }
    }

    public void NextSentence()
    {
        continueButton.SetActive(false);

        if (Index < Sentences.Length - 1)
        {
            Index++;
            DialogText.text = "";
            StartCoroutine(WriteSentence());
        }
        else
        {
            DialogText.text = "";
            continueButton.SetActive(false);
            
        }
    }


    IEnumerator WriteSentence()
    {
        foreach(char Character in Sentences[Index].ToCharArray())
        {
            DialogText.text += Character;
            yield return new WaitForSeconds(DialogSpeed);
          
        }
        
    }
}
