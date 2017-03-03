﻿using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonBehavior : MonoBehaviour, ISelectHandler, IDeselectHandler, IPointerEnterHandler, IPointerExitHandler {

    private Text _text;

    private void OnEnable() {
        _text = GetComponentInChildren<Text>();
    }

    public void OnSelect(BaseEventData eventData) {
        _text.color = Color.cyan;
    }

    public void OnDeselect(BaseEventData eventData) {
        _text.color = Color.black;
    }

    public void OnPointerEnter(PointerEventData data) {
        _text.color = Color.cyan;
    }

    public void OnPointerExit(PointerEventData data) {
        _text.color = Color.black;
    }
}