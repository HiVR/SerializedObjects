// <copyright file="SerializableVector3Test.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>

namespace SerializedObjects
{
    using NUnit.Framework;

    /// <summary>
    /// Test <see cref="SerializableVector3"/> class.
    /// </summary>
    public class SerializableVector3Test
    {
        #region Methods

        /// <summary>
        /// Test Empty Constructor.
        /// </summary>
        [Test]
        public void TestEmptyConstructor()
        {
            Assert.True(new SerializableVector3() is SerializableVector3);
        }

        /// <summary>
        /// Test Constructor.
        /// </summary>
        [Test]
        public void TestConstructor()
        {
            float x = 1F;
            float y = 2F;
            float z = 3F;

            SerializableVector3 constructor = new SerializableVector3(x, y, z);
            Assert.True(constructor is SerializableVector3);

            Assert.That(constructor.X, Is.EqualTo(x));
            Assert.That(constructor.Y, Is.EqualTo(y));
            Assert.That(constructor.Z, Is.EqualTo(z));
        }

        /// <summary>
        /// Test <see cref="SerializableVector3.X"/> field.
        /// </summary>
        [Test]
        public void TestX()
        {
            SerializableVector3 constructor = new SerializableVector3();
            float x = 4F;

            constructor.X = x;
            Assert.That(constructor.X, Is.EqualTo(x));
        }

        /// <summary>
        /// Test <see cref="SerializableVector3.Y"/> field.
        /// </summary>
        [Test]
        public void TestY()
        {
            SerializableVector3 constructor = new SerializableVector3();
            float y = 5F;

            constructor.Y = y;
            Assert.That(constructor.Y, Is.EqualTo(y));
        }

        /// <summary>
        /// Test <see cref="SerializableVector3.Z"/> field.
        /// </summary>
        [Test]
        public void TestZ()
        {
            SerializableVector3 constructor = new SerializableVector3();
            float z = 6F;

            constructor.Z = z;
            Assert.That(constructor.Z, Is.EqualTo(z));
        }

        #endregion Methods
    }
}