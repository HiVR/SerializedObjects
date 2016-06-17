// <copyright file="SerializableCharacterTest.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>

namespace SerializedObjects
{
    using NUnit.Framework;

    /// <summary>
    /// Test <see cref="SerializableCharacter"/> class.
    /// </summary>
    public class SerializableCharacterTest
    {
        #region Methods

        /// <summary>
        /// Test Empty Constructor.
        /// </summary>
        [Test]
        public void TestEmptyConstructor()
        {
            Assert.True(new SerializableCharacter() is SerializableCharacter);
        }

        /// <summary>
        /// Test Constructor.
        /// </summary>
        [Test]
        public void TestConstructor()
        {
            bool isPatient = true;
            string name = "TestConstructor";

            SerializableCharacter constructor = new SerializableCharacter(isPatient, name);
            Assert.True(constructor is SerializableCharacter);

            Assert.That(constructor.IsPatient, Is.EqualTo(isPatient));
            Assert.That(constructor.Name, Is.EqualTo(name));
        }

        /// <summary>
        /// Test <see cref="SerializableCharacter.IsPatient"/> field.
        /// </summary>
        [Test]
        public void TestisPatient()
        {
            SerializableCharacter constructor = new SerializableCharacter();
            bool isPatient = true;

            constructor.IsPatient = isPatient;
            Assert.That(constructor.IsPatient, Is.EqualTo(isPatient));
        }

        /// <summary>
        /// Test <see cref="SerializableCharacter.Name"/> field.
        /// </summary>
        [Test]
        public void TestName()
        {
            SerializableCharacter constructor = new SerializableCharacter();
            string name = "TestName";

            constructor.Name = name;
            Assert.That(constructor.Name, Is.EqualTo(name));
        }

        #endregion Methods
    }
}