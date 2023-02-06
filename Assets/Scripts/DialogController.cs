using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogController : MonoBehaviour
{
    public Text dialogText;
    // Start is called before the first frame update
    void Start()
    {
        dialogText.text = "";
        string sampleText = "안녕하세요 셰플러코리아님, \n무엇을 도와드릴까요?";
        StartCoroutine(Typing(sampleText));
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Typing(string text)
    {
        foreach(char letter in text.ToCharArray())
        {
            dialogText.text += letter;
            yield return new WaitForSeconds(0.1f);
        }
    }
}
