﻿using UnityEngine;
using System.Collections;

public class Aiming : AbstractPlayerActions {

    protected override void OnEnable() {
        ControllableObject.OnButton += OnButton;
        ControllableObject.OnButtonUp += OnButtonUp;
    }

    protected override void OnDisable() {
        ControllableObject.OnButton -= OnButton;
        ControllableObject.OnButtonUp -= OnButtonUp;
    }

    private void OnButton(Buttons button) {
        switch (button) {

            case Buttons.AimRight:
                _controller.AimDirection.Right = true;
                break;
            case Buttons.AimLeft:
                _controller.AimDirection.Left = true;
                break;
            case Buttons.AimUp:
                _controller.AimDirection.Up = true;
                break;
            case Buttons.AimDown:
                _controller.AimDirection.Down = true;
                break;
        }

        //if (button == Buttons.AimRight) {
        //    _controller.AimDirection.Right = true;
        //}
        //else if (button == Buttons.AimLeft) {
        //    _controller.AimDirection.Left = true;
        //}
        //else if (button == Buttons.AimUp) {
        //    _controller.AimDirection.Up = true;
        //}
        //else if (button == Buttons.AimDown) {
        //    _controller.AimDirection.Down = true;
        //}
    }

    private void OnButtonUp(Buttons button) {

        switch (button) {

            case Buttons.AimRight:
                _controller.AimDirection.Right = false;
                break;
            case Buttons.AimLeft:
                _controller.AimDirection.Left = false;
                break;
            case Buttons.AimUp:
                _controller.AimDirection.Up = false;
                break;
            case Buttons.AimDown:
                _controller.AimDirection.Down = false;
                break;
        }

        //if (button == Buttons.AimRight) {
        //    _controller.AimDirection.Right = false;
        //}
        //else if (button == Buttons.AimLeft) {
        //    _controller.AimDirection.Left = false;
        //}
        //else if (button == Buttons.AimUp) {
        //    _controller.AimDirection.Up = false;
        //}
        //else if (button == Buttons.AimDown) {
        //    _controller.AimDirection.Down = false;
        //}
    }
}
