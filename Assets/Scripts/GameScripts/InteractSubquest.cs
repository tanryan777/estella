﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class InteractSubquest : SubQuest
{
    public string InteractableObjectName;

    public override bool QuestCheck()
    {
        Debug.Log(GameObject.Find(InteractableObjectName).GetComponent<InteractableObject>().isActivated);
        if (GameObject.Find(InteractableObjectName).GetComponent<InteractableObject>().isActivated)
        {
            Debug.Log("Done");
            return true;
        }

        return false;
    }
}
