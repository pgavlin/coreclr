using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _interlocked_add_InterlockedAddLong_1_InterlockedAddLong_1_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_add_InterlockedAddLong_1_InterlockedAddLong_1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\add\\InterlockedAddLong_1\\InterlockedAddLong_1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
