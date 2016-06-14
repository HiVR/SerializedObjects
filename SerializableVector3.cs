// <copyright file="SerializableVector3.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
namespace SerializedObjects
{
    using System;

    /// <summary>
    /// Holds three floating point values, is serializable.
    /// </summary>
    [Serializable]
    public class SerializableVector3
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableVector3"/> class.
        /// </summary>
        public SerializableVector3()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableVector3"/> class.
        /// </summary>
        /// <param name="x">the x parameter</param>
        /// <param name="y">the y parameter</param>
        /// <param name="z">the z parameter</param>
        public SerializableVector3(float x, float y, float z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        #endregion Constructors

        #region Properties

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