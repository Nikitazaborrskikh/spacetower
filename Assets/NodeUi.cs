using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeUi : MonoBehaviour
{
   private node target;
   public GameObject ui;
   public void SetTarget(node _target)
   {
       target = _target;
       transform.position = target.GetBuildPosition();
       ui.SetActive(true);
   }

   public void Hide()
   {
       ui.SetActive(false);
   }
}
