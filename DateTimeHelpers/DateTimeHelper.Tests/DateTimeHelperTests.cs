using DateTimeHelpers;
using System;
using Xunit;

namespace DateTimeHelper.Tests
{
    public class DateTimeHelperTests : IDisposable
    {
        private DateTimeHelpers.DateTimeHelper dth;

        public DateTimeHelperTests()
        {
            dth = new DateTimeHelpers.DateTimeHelper();
        }

        public void Dispose()
        {
        }

        [Fact]
        public void UnixToUTCTest_Milliseconds()
        {
            var unixTime = 1536003037961;
            var expected = new DateTime(2018, 9, 3, 19, 30, 37, 961);
            
            var utcTime = dth.UnixTimeToUTC(unixTime);

            Assert.Equal(expected, utcTime);
        }

        [Fact]
        public void UnixToUTCTest_Milliseconds_Fail()
        {
            var unixTime = 1536003037961;
            var expected = new DateTime(2018, 9, 3, 19, 30, 37);

            var utcTime = dth.UnixTimeToUTC(unixTime);

            Assert.NotEqual(expected, utcTime);
        }

        [Fact]
        public void UnixToUTCTest_NoMilliseconds()
        {
            var unixTime = 1536003037;
            var expected = new DateTime(2018, 9, 3, 19, 30, 37);

            var utcTime = dth.UnixTimeToUTC(unixTime);

            Assert.Equal(expected, utcTime);
        }

        [Fact]
        public void UnixToUTCTest_NoMilliseconds_Fail()
        {
            var unixTime = 1536003037;
            var expected = new DateTime(2018, 9, 3, 19, 30, 37, 961);

            var utcTime = dth.UnixTimeToUTC(unixTime);

            Assert.NotEqual(expected, utcTime);
        }
    }
}
