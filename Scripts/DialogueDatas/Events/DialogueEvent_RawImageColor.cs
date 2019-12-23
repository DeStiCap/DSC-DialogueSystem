﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DSC.DialogueSystem
{
    [CreateAssetMenu(fileName = "DialogueEvent_RawImageColor", menuName = "DSC/Dialogue/Events/Raw Image Color")]
    public class DialogueEvent_RawImageColor : DialogueEvent
    {
        #region Variable

        #region Variable - Inspector
#pragma warning disable 0649

        [SerializeField] int m_nIndex;
        [SerializeField] Color m_hColor;

#pragma warning restore 0649
        #endregion

        #endregion

        #region Base - Override

        public override void OnStart(List<IDialogueEventData> lstData)
        {
            base.OnStart(lstData);

            if (!lstData.TryGetData(out DialogueEventData_GroupController<DSC_Dialogue_RawImageGroupController> hOutData))
                return;

            var hGroupController = hOutData.m_hGroupController;
            if (hGroupController == null)
                return;

            hGroupController.SetColor(m_nIndex, m_hColor);
        }

        #endregion
    }
}