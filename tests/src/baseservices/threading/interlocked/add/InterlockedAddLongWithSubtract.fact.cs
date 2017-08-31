using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _interlocked_add_InterlockedAddLongWithSubtract_InterlockedAddLongWithSubtract_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_add_InterlockedAddLongWithSubtract_InterlockedAddLongWithSubtract_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\add\\InterlockedAddLongWithSubtract\\InterlockedAddLongWithSubtract.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
