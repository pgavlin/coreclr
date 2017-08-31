using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _interlocked_add_InterlockedAddInt_2_InterlockedAddInt_2_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_add_InterlockedAddInt_2_InterlockedAddInt_2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\add\\InterlockedAddInt_2\\InterlockedAddInt_2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
