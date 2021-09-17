﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetalDelivery : MonoBehaviour
{
    public BoxCollider2D BoxColl;
    public ItemGenerator ItemGen;
    public UIController UI;

    [SerializeField]
    private AudioClip Right;
    private bool rightS = false;
    private bool wrongS = false;

    private bool Tounching = false;
    // Start is called before the first frame update
    void Start()
    {
        Implements();
    }

    // Update is called once per frame
    void Update()
    {
        DeliveryCheck();
    }
    private void Implements()
    {
        BoxColl = GetComponent<BoxCollider2D>();
    }
    private void DeliveryCheck()
    {
        if (Tounching == true && Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("CheckPoint41");
            if (ItemGen.HaveItem != false && ItemGen.TypeGenerator >= 12 && ItemGen.TypeGenerator <= 14)
            {
                Debug.Log("CheckPoint42");
                UI.ScoreAdd();
                ItemGen.HaveItem = false;
                rightS = true;
                return;
            }
            else if (ItemGen.HaveItem != false && ItemGen.TypeGenerator < 12)
            {
                Debug.Log("CheckPoint43");
                UI.ScoreLess();
                ItemGen.HaveItem = false;
                return;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Tounching = true;
        return;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Tounching = false;
        return;
    }
}