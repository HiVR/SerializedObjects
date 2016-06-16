using NUnit.Framework;

namespace SerializedObjects
{
    public class SerializableCharacterTest
    {
        #region Methods

        [Test]
        public void TestEmptyConstructor()
        {
            Assert.True(new SerializableCharacter() is SerializableCharacter);
        }

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

        [Test]
        public void TestisPatient()
        {
            SerializableCharacter constructor = new SerializableCharacter();
            bool isPatient = true;

            constructor.IsPatient = isPatient;
            Assert.That(constructor.IsPatient, Is.EqualTo(isPatient));
        }

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