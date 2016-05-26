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
        #region Fields

        /// <summary>
        /// Float: x value
        /// </summary>
        public float x { get; set; }

        /// <summary>
        /// Float: y value
        /// </summary>
        public float y { get; set; }

        /// <summary>
        /// Float: z value
        /// </summary>
        public float z { get; set; }

        #endregion Fields

        #region Methods

        /// <summary>
        /// Empty constructor
        /// </summary>
        public SerializableVector3()
        {
        }

        /// <summary>
        /// Constructor with all three values
        /// </summary>
        public SerializableVector3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        #endregion Methods
    }
}
