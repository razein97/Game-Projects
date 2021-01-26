﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MetaGameJam
{
    public static class Vector3_Vector2
    {
        public static Vector2 toVector2(this Vector3 vec3)
        {
            return new Vector2(vec3.x, vec3.y);
        }
    }

}

