using NUnit.Framework;

namespace SerializedObjects
{
    public class SerializableVector3Test
    {
        #region Methods

        [Test]
        public void TestEmptyConstructor()
        {
            Assert.True(new SerializableVector3() is SerializableVector3);
        }

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

        [Test]
        public void TestX()
        {
            SerializableVector3 constructor = new SerializableVector3();
            float x = 4F;

            constructor.X = x;
            Assert.That(constructor.X, Is.EqualTo(x));
        }

        [Test]
        public void TestY()
        {
            SerializableVector3 constructor = new SerializableVector3();
            float y = 5F;

            constructor.Y = y;
            Assert.That(constructor.Y, Is.EqualTo(y));
        }

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