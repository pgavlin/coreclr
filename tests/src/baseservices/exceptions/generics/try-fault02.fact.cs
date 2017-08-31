using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _generics_try_fault02_try_fault02_
    {
        [OuterLoop]
        [Fact]
        public void _generics_try_fault02_try_fault02_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\generics\\try-fault02\\try-fault02.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
