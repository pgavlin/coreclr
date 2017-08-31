using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _interlocked_add_InterlockedAddInt_InterlockedAddInt_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_add_InterlockedAddInt_InterlockedAddInt_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\add\\InterlockedAddInt\\InterlockedAddInt.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
