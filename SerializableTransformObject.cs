// <copyright file="SerializableTransformObject.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
namespace SerializedObjects
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Sockets;
    using System.Runtime.Serialization.Formatters.Binary;

    /// <summary>
    /// Serializable data class; contains position, scale and rotation vectors.
    /// Can be Serialized and DeSerialized with supplied methods.
    /// </summary>
    [Serializable]
    public class SerializableTransformObject
    {
        #region Fields

        /// <summary>
        /// Socket used for sending/receiving binary data.
        /// </summary>
        [NonSerialized]
        public Socket socket;

        /// <summary>
        /// List of bytes used for retrieving binary stream of unknown length.
        /// </summary>
        [NonSerialized]
        public List<byte> transmissionBuffer = new List<byte>();

        /// <summary>
        /// Byte buffer used to receive part of binary stream.
        /// </summary>
        [NonSerialized]
        public byte[] buffer = new byte[2048];

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableTransformObject"/> class.
        /// </summary>
        public SerializableTransformObject()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableTransformObject"/> class.
        /// </summary>
        /// <param name="id">the id of the object</param>
        /// <param name="type">the type of the object</param>
        /// <param name="isStatic">whether the object is static or not</param>
        /// <param name="position">the position vector of the object</param>
        /// <param name="scale">the scale vector of the object</param>
        /// <param name="rotation">the rotation vector of the object</param>
        public SerializableTransformObject(int id, string type, bool isStatic, SerializableVector3 position, SerializableVector3 scale, SerializableVector4 rotation)
        {
            this.Id = id;
            this.Type = type;
            this.IsStatic = isStatic;

            this.Position = position;
            this.Scale = scale;
            this.Rotation = rotation;
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the id of the object.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the type of the object.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the object is static or not.
        /// </summary>
        public bool IsStatic { get; set; }

        /// <summary>
        /// Gets or sets the position vector of the object.
        /// </summary>
        public SerializableVector3 Position { get; set; }

        /// <summary>
        /// Gets or sets the scale vector of the object.
        /// </summary>
        public SerializableVector3 Scale { get; set; }

        /// <summary>
        /// Gets or sets the rotation vector of the object.
        /// </summary>
        public SerializableVector4 Rotation { get; set; }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Serialize this object into a byte buffer.
        /// </summary>
        /// <returns>serialized object</returns>
        public byte[] Serialize()
        {
            var bin = new BinaryFormatter();
            var mem = new MemoryStream();
            bin.Serialize(mem, this);
            return mem.GetBuffer();
        }

        /// <summary>
        /// DeSerialize this object from a byte buffer.
        /// </summary>
        /// <returns>deserialized object</returns>
        public SerializableTransformObject DeSerialize()
        {
            var dataBuffer = this.transmissionBuffer.ToArray();
            var bin = new BinaryFormatter();
            var mem = new MemoryStream();
            mem.Write(dataBuffer, 0, dataBuffer.Length);
            mem.Seek(0, 0);
            return (SerializableTransformObject)bin.Deserialize(mem);
        }

        #endregion Methods
    }
}