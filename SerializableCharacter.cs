// <copyright file="SerializableCharacter.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
namespace SerializedObjects
{
    using System;

    /// <summary>
    /// Holds information about a character, is serializable.
    /// </summary>
    [Serializable]
    public class SerializableCharacter
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableCharacter"/> class.
        /// </summary>
        public SerializableCharacter()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableCharacter"/> class.
        /// </summary>
        /// <param name="isPatient">is the character the patient</param>
        /// <param name="name">the name of the character</param>
        public SerializableCharacter(bool isPatient, string name)
        {
            this.IsPatient = isPatient;
            this.Name = name;
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets a value indicating whether the character is a patient.
        /// </summary>
        public bool IsPatient { get; set; }

        /// <summary>
        /// Gets or sets the name of the character.
        /// </summary>
        public string Name { get; set; }

        #endregion Properties
    }
}