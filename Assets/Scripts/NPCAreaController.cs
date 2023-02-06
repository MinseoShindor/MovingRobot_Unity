using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCAreaController : MonoBehaviour
{
    public GameObject NPC;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag == "Player") 
        {
            GameObject canvas = GameObject.FindWithTag("Canvas");
            if (canvas == null)
            {
                return ;
            } //nullReferenceException 1) canvas

            Transform transform = canvas.transform;
            GameObject panel = transform.Find("Panel").gameObject;
            GameObject joysticksCanvas = transform.Find("UI_Canvas_StarterAssetsInputs_Joysticks").gameObject;

            if (panel == null)
            {
                return ;
            } //nullReferenceException 2) panel
        
            panel.SetActive(true);
        }

    }
}
