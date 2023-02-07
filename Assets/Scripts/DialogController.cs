using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class DialogController : MonoBehaviour
{
    public Text dialogText;
    public UnityEvent onDialogFinished;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartDialog()
    {
        dialogText.text = "";
        string sampleText = "안녕하세요 셰플러코리아님, \n무엇을 도와드릴까요?";
        StartCoroutine(Typing(sampleText));
    }

    public void FinishDialog()
    {
        gameObject.SetActive(false);
        StopAllCoroutines();
        onDialogFinished.Invoke();

    }

    IEnumerator Typing(string text)
    {
        foreach(char letter in text.ToCharArray())
        {
            dialogText.text += letter;
            yield return new WaitForSeconds(0.1f);
        }

        //TODO
        yield return new WaitForSeconds(0.5f);
        FinishDialog();
    }
}
