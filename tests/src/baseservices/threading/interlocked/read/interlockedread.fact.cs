using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _interlocked_read_interlockedread_interlockedread_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_read_interlockedread_interlockedread_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\read\\interlockedread\\interlockedread.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
