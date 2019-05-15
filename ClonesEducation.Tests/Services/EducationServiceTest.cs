using ClonesEducation.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ClonesEducation.Tests.Services
{
    public class EducationServiceTest
    {
        [Theory]
        [InlineData(0)]
        [InlineData(2)]
        [InlineData(10)]
        [InlineData(20)]
        [InlineData(30)]
        public void GetTimeForLearnSubjectTests(int boost)
        {
            var educationService = new EducationService();

            var resultExpected = educationService.BaseEducateTime;
            var resultActual = educationService.GetTimeForLearnSubject(boost);

            if (boost >= 2 && boost <= 10)
                resultExpected = resultExpected / boost;

            if (boost == 20)
                resultExpected = new TimeSpan(0);

            Assert.Equal(resultExpected, resultActual);
        }
    }
}
