// <copyright file="SerializableVector4.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
namespace SerializedObjects
{
    using System;

    /// <summary>
    /// Holds three floating point values, is serializable.
    /// </summary>
    [Serializable]
    public class SerializableVector4
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableVector4"/> class.
        /// </summary>
        public SerializableVector4()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableVector4"/> class.
        /// </summary>
        /// <param name="w">the w parameter</param>
        /// <param name="x">the x parameter</param>
        /// <param name="y">the y parameter</param>
        /// <param name="z">the z parameter</param>
        public SerializableVector4(float w, float x, float y, float z)
        {
            this.W = w;
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the w parameter of the vector.
        /// </summary>
        public float W { get; set; }

        /// <summary>
        /// Gets or sets the x parameter of the vector.
        /// </summary>
        public float X { get; set; }

        /// <summary>
        /// Gets or sets the y parameter of the vector.
        /// </summary>
        public float Y { get; set; }

        /// <summary>
        /// Gets or sets the z parameter of the vector.
        /// </summary>
        public float Z { get; set; }

        #endregion Properties
    }
}