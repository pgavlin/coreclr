using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _generics_try_fault01_try_fault01_
    {
        [OuterLoop]
        [Fact]
        public void _generics_try_fault01_try_fault01_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\generics\\try-fault01\\try-fault01.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
