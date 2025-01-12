using Logic.DTOs;
using Logic.Entities;
using Logic.Utils;

namespace Unit_Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DoesMapperMapTagDTOToTag()
        {
            //Arrange
            Guid guid = Guid.NewGuid();
            TagDTO dto = new TagDTO(guid, "test");
            Tag testTag;
            Tag tag = new Tag(guid, "test");
            //Act
            testTag = Mapper.MapTagDTOToTag(dto);
            //Assert
            Assert.AreEqual(testTag.ID, tag.ID);
            Assert.AreEqual(testTag.Name, tag.Name);
        }

        [Test]
        public void DoesMapperMapTagDTOToTag_EmptyGUID()
        {
            //Arrange
            Guid guid = Guid.Empty;
            TagDTO dto = new TagDTO(guid, "test");
            Tag testTag;
            Tag tag = new Tag(guid, "test");
            //Act
            testTag = Mapper.MapTagDTOToTag(dto);
            //Assert
            Assert.AreEqual(testTag.ID, tag.ID);
            Assert.AreEqual(testTag.Name, tag.Name);
        }
    }
}