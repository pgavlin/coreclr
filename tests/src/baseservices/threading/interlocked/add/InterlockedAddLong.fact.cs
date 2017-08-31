using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _interlocked_add_InterlockedAddLong_InterlockedAddLong_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_add_InterlockedAddLong_InterlockedAddLong_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\add\\InterlockedAddLong\\InterlockedAddLong.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
