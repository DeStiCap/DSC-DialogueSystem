﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DSC.DialogueSystem
{
    [RequireComponent(typeof(Image))]
    public class DSC_Dialogue_ImageController : MonoBehaviour
    {
        #region Variable

        #region Variable - Inspector
#pragma warning disable 0649

        [SerializeField] int m_nIndex;

#pragma warning restore 0649
        #endregion

        #region Variable - Property

        public int Index { get { return m_nIndex; } }

        #endregion

        RectTransform m_hRectTransform;
        Image m_hImage;

        #endregion

        #region Base - Mono

        private void Awake()
        {
            m_hRectTransform = GetComponent<RectTransform>();
            m_hImage = GetComponent<Image>();
        }

        #endregion

        #region Main

        public void SetImage(Sprite hSprite)
        {
            m_hImage.sprite = hSprite;
        }

        public void SetPosition(Vector2 vPosition)
        {
            m_hRectTransform.anchoredPosition = vPosition;   
        }

        public void ShowImage()
        {
            m_hImage.enabled = true;
        }

        public void HideImage()
        {
            m_hImage.enabled = false;
        }

        #endregion
    }
}