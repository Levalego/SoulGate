﻿using UnityEngine;

/// <summary>
/// State of the motor sent from the server.
/// </summary>
public struct ServerMotorState
{
    public uint FixedFrame;
    public Vector3 Position;
    public Quaternion Rotation;
    public Vector3 Velocity;
    public Vector3 AngularVelocity;
    public sbyte TimingStepChange;
    public Vector3 Destination;
}