﻿using UnityEngine;
using System.Collections;

/*
 * This class will act as the base class for all weapons in the game.
 */

public abstract class AbstractGun : MonoBehaviour {

    // Delegate to work with UI
    public delegate void AbstractGunEvent(int numOfRounds);
    // Delegate to work with ScreenShake feature
    public delegate void AbstractGunEvent2();
    public delegate void AbstractGunEvent3(float reloadTime);


    [SerializeField]
    protected WeaponType _type;
    [SerializeField]
    protected SOWeaponManager _weaponManager;

    [SerializeField]
    protected MovementRequest _moveRequest;
    [SerializeField]
    protected ScreenShakeRequest _SSRequest;
    [SerializeField]
    protected SOEffects _SOEffectHandler;
    [SerializeField]
    protected AudioClip _audioClip;

    protected AudioSource _audioSource;

    [SerializeField]
    protected int _ammoCapacity;

    public int numOfRounds;

    [SerializeField]
    protected float _shotDelay;
    [SerializeField]
    protected float _reloadTime;

    protected bool _reloading = false;
    // This keeps a state of whether the player was in the air or not
    // when the reload was called. This is to prevent the player from calling
    // reload when they landed, switching weapons, and the the slow reload is called.
    protected bool _grounded;

    protected bool _canShoot = true;
    protected bool _damaged = false;

    protected ControllableObject _controller;
    protected PlayerCollisionState _collisionState;

    [Space]
    [Header("Bullet Direction")]
    [Header("Not Aiming 270")]
    [SerializeField]
    protected Transform _barrelNorm;
    [SerializeField]
    protected Transform _endNorm;

    [Header("Aiming 270")]
    [SerializeField]
    protected Transform _barrelAlt;
    [SerializeField]
    protected Transform _endAlt;

    protected Vector2 _direction = Vector2.zero;

    protected virtual void Awake() {

        _controller = GameObject.FindGameObjectWithTag("Player").GetComponent<ControllableObject>();
        _collisionState = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerCollisionState>();
    }

    protected virtual void OnButtonDown(Buttons button) { }
}