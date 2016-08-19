﻿// <copyright file="AchromatomalyProcessor.cs" company="James Jackson-South">
// Copyright (c) James Jackson-South and contributors.
// Licensed under the Apache License, Version 2.0.
// </copyright>

namespace ImageProcessorCore.Processors
{
    using System.Numerics;

    /// <summary>
    /// Converts the colors of the image recreating Achromatomaly (Color desensitivity) color blindness.
    /// </summary>
    /// <typeparam name="T">The pixel format.</typeparam>
    /// <typeparam name="TP">The packed format. <example>long, float.</example></typeparam>
    public class AchromatomalyProcessor<T, TC, TP> : ColorMatrixFilter<T, TC, TP>
        where T : IPackedVector<TP>
        where TP : struct
    {
        /// <inheritdoc/>
        public override Matrix4x4 Matrix => new Matrix4x4()
        {
            M11 = .618f,
            M12 = .163f,
            M13 = .163f,
            M21 = .320f,
            M22 = .775f,
            M23 = .320f,
            M31 = .062f,
            M32 = .062f,
            M33 = .516f
        };

        /// <inheritdoc/>
        public override bool Compand => false;
    }
}
