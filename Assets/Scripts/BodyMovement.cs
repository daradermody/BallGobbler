﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Utils;
using Random = UnityEngine.Random;

public class BodyMovement : Movement {

    public MovementSprites body;

    void Start() {
        SetSprites(body);
    }

    public void Gobble(Direction direction) {
        base.Gobble(GetGobbleSprite(direction), WaitCor(gobbleShakeDuration));
    }
    
    private Sprite GetGobbleSprite(Direction direction) {
        if (direction == Direction.Left) {
            return body.openLeft;
        }

        if (direction == Direction.Middle) {
            return body.openMiddle;
        }

        return body.openRight;
    }
    
    IEnumerator WaitCor(float totalShakeDuration)
    {
        float counter = 0f;
        while (counter < totalShakeDuration) {
            yield return null;
        }
        _isGobbling = false;
    }
}