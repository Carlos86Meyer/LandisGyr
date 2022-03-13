using ConsoleLandis.Control;
using ConsoleLandis.Model;
using System;
using System.Collections.Generic;
using Xunit;

namespace XUnitTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            IEnumerable<EndPointDTO> endPointDTOs = new List<EndPointDTO>();

            Moq.Mock<EndPointBO> mock = new Moq.Mock<EndPointBO>();
            mock.Setup(x => x.InsertNewEndPoint(endPointDTOs));

            EndPointBO endPointBO = new EndPointBO();


        }
    }
}
