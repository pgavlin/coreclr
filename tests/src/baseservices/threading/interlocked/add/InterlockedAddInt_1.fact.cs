using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _interlocked_add_InterlockedAddInt_1_InterlockedAddInt_1_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_add_InterlockedAddInt_1_InterlockedAddInt_1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\add\\InterlockedAddInt_1\\InterlockedAddInt_1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
