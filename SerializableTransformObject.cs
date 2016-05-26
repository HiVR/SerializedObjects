// <copyright file="SerializableTransformObject.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
namespace SerializedObjects
{
    using System;
    using System.Collections.Generic;
    using System.Net.Sockets;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.IO;

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
        public Socket Socket;

        /// <summary>
        /// List of bytes used for retrieving binary stream of unknown length.
        /// </summary>
        [NonSerialized]
        public List<byte> TransmissionBuffer = new List<byte>();

        /// <summary>
        /// Byte buffer used to receive part of binary stream.
        /// </summary>
        [NonSerialized]
        public byte[] buffer = new byte[2048];

        /// <summary>
        /// Value: id
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// Value: type
        /// </summary>
        public int type { get; set; }

        /// <summary>
        /// Value: isStatic
        /// </summary>
        public bool isStatic { get; set; }

        /// <summary>
        /// Value: position
        /// </summary>
        public SerializableVector3 position { get; set; }

        /// <summary>
        /// Value: scale
        /// </summary>
        public SerializableVector3 scale { get; set; }

        /// <summary>
        /// Value: rotation
        /// </summary>
        public SerializableVector4 rotation { get; set; }

        #endregion Fields

        #region Methods

        /// <summary>
        /// Empty constructor.
        /// </summary>
        public SerializableTransformObject()
        {
        }

        /// <summary>
        /// Constructor to initialize instance with values.
        /// </summary>
        public SerializableTransformObject(int id, int type, bool isStatic, SerializableVector3 position, SerializableVector3 scale, SerializableVector4 rotation)
        {
            this.id = id;
            this.type = type;
            this.isStatic = isStatic;

            this.position = position;
            this.scale = scale;
            this.rotation = rotation;
        }

        /// <summary>
        /// Serialize this object into a byte buffer.
        /// </summary>
        public byte[] Serialize()
        {
            BinaryFormatter bin = new BinaryFormatter();
            MemoryStream mem = new MemoryStream();
            bin.Serialize(mem, this);
            return mem.GetBuffer();
        }

        /// <summary>
        /// DeSerialize this object from a byte buffer.
        /// </summary>
        public SerializableTransformObject DeSerialize()
        {
            byte[] dataBuffer = TransmissionBuffer.ToArray();
            BinaryFormatter bin = new BinaryFormatter();
            MemoryStream mem = new MemoryStream();
            mem.Write(dataBuffer, 0, dataBuffer.Length);
            mem.Seek(0, 0);
            return (SerializableTransformObject)bin.Deserialize(mem);
        }

        #endregion Methods
    }
}
