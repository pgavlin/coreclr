using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _interlocked_add_InterlockedAddLong_2_InterlockedAddLong_2_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_add_InterlockedAddLong_2_InterlockedAddLong_2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\add\\InterlockedAddLong_2\\InterlockedAddLong_2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
