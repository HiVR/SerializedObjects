using NUnit.Framework;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace SerializedObjects
{
    public class SerializableTransformObjectTest
    {
        #region Methods

        [Test]
        public void TestEmptyConstructor()
        {
            Assert.True(new SerializableTransformObject() is SerializableTransformObject);
        }

        [Test]
        public void TestConstructor()
        {
            int id = 0;
            SerializableType type = SerializableType.Bench;
            bool isStatic = true;
            SerializableVector3 position = new SerializableVector3(0, 0, 0);
            SerializableVector3 scale = new SerializableVector3(1, 1, 1);
            SerializableVector3 rotation = new SerializableVector3(2, 2, 2);
            SerializableCharacter character = new SerializableCharacter(true, "Test");

            SerializableTransformObject constructor = new SerializableTransformObject(id, type, isStatic, position, scale, rotation, character);
            Assert.True(constructor is SerializableTransformObject);

            Assert.That(constructor.Id, Is.EqualTo(id));
            Assert.That(constructor.Type, Is.EqualTo(type));
            Assert.That(constructor.IsStatic, Is.EqualTo(isStatic));
            Assert.That(constructor.Position, Is.EqualTo(position));
            Assert.That(constructor.Scale, Is.EqualTo(scale));
            Assert.That(constructor.Rotation, Is.EqualTo(rotation));
            Assert.That(constructor.Character, Is.EqualTo(character));
        }

        [Test]
        public void TestBuffer()
        {
            SerializableTransformObject constructor = new SerializableTransformObject();
            byte[] buffer = Encoding.ASCII.GetBytes("TestBuffer");

            constructor.Buffer = buffer;
            Assert.That(constructor.Buffer, Is.EqualTo(buffer));
        }

        [Test]
        public void TestTransmissionBuffer()
        {
            SerializableTransformObject constructor = new SerializableTransformObject();
            List<byte> transmissionBuffer = new List<byte>();
            transmissionBuffer.AddRange(Encoding.ASCII.GetBytes("TestTransmissionBuffer"));

            constructor.TransmissionBuffer = transmissionBuffer;
            Assert.That(constructor.TransmissionBuffer, Is.EqualTo(transmissionBuffer));
        }

        [Test]
        public void TestSocket()
        {
            SerializableTransformObject constructor = new SerializableTransformObject();
            Socket socket = new Socket(AddressFamily.InterNetworkV6, SocketType.Stream, ProtocolType.Tcp);

            constructor.Socket = socket;
            Assert.That(constructor.Socket, Is.EqualTo(socket));
        }

        [Test]
        public void TestId()
        {
            SerializableTransformObject constructor = new SerializableTransformObject();
            int id = 104693;

            constructor.Id = id;
            Assert.That(constructor.Id, Is.EqualTo(id));
        }

        [Test]
        public void TestType()
        {
            SerializableTransformObject constructor = new SerializableTransformObject();
            SerializableType type = SerializableType.Television;

            constructor.Type = type;
            Assert.That(constructor.Type, Is.EqualTo(type));
        }

        [Test]
        public void TestIsStatic()
        {
            SerializableTransformObject constructor = new SerializableTransformObject();
            bool isStatic = true;

            constructor.IsStatic = isStatic;
            Assert.That(constructor.IsStatic, Is.EqualTo(isStatic));
        }

        [Test]
        public void TestPosition()
        {
            SerializableTransformObject constructor = new SerializableTransformObject();
            SerializableVector3 position = new SerializableVector3(1, 2, 3);

            constructor.Position = position;
            Assert.That(constructor.Position, Is.EqualTo(position));
        }

        [Test]
        public void TestScale()
        {
            SerializableTransformObject constructor = new SerializableTransformObject();
            SerializableVector3 scale = new SerializableVector3(2, 3, 4);

            constructor.Scale = scale;
            Assert.That(constructor.Scale, Is.EqualTo(scale));
        }

        [Test]
        public void TestRotation()
        {
            SerializableTransformObject constructor = new SerializableTransformObject();
            SerializableVector3 rotation = new SerializableVector3(3, 4, 5);

            constructor.Rotation = rotation;
            Assert.That(constructor.Rotation, Is.EqualTo(rotation));
        }

        [Test]
        public void TestCharacter()
        {
            SerializableTransformObject constructor = new SerializableTransformObject();
            SerializableCharacter character = new SerializableCharacter(true, "Test");

            constructor.Character = character;
            Assert.That(constructor.Character, Is.EqualTo(character));
        }

        [Test]
        public void TestSerializeDeserialize()
        {
            // Initialize values
            int id = 0;
            SerializableType type = SerializableType.Bench;
            bool isStatic = true;
            SerializableVector3 position = new SerializableVector3(0, 0, 0);
            SerializableVector3 scale = new SerializableVector3(1, 1, 1);
            SerializableVector3 rotation = new SerializableVector3(2, 2, 2);
            SerializableCharacter character = new SerializableCharacter(true, "Test");

            // Serialize constructor
            SerializableTransformObject constructor = new SerializableTransformObject(id, type, isStatic, position, scale, rotation, character);
            byte[] serialized = constructor.Serialize();

            // Create new SerializableTransformObject, add the serialized buffer to it
            SerializableTransformObject check = new SerializableTransformObject();
            List<byte> transmissionBuffer = new List<byte>();
            transmissionBuffer.AddRange(serialized);
            check.TransmissionBuffer = transmissionBuffer;

            // De-serialize
            SerializableTransformObject deserialized = check.DeSerialize();

            // Check the values
            Assert.That(deserialized.Id, Is.EqualTo(constructor.Id));
            Assert.That(deserialized.Type, Is.EqualTo(constructor.Type));
            Assert.That(deserialized.IsStatic, Is.EqualTo(constructor.IsStatic));
            Assert.That(deserialized.Position.X, Is.EqualTo(constructor.Position.X));
            Assert.That(deserialized.Scale.Y, Is.EqualTo(constructor.Scale.Y));
            Assert.That(deserialized.Rotation.Z, Is.EqualTo(constructor.Rotation.Z));
            Assert.That(deserialized.Character.Name, Is.EqualTo(constructor.Character.Name));
        }

        #endregion Methods
    }
}