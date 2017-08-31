using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _interlocked_add_interlockedaddintwithsubtract_interlockedaddintwithsubtract_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_add_interlockedaddintwithsubtract_interlockedaddintwithsubtract_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\add\\interlockedaddintwithsubtract\\interlockedaddintwithsubtract.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
