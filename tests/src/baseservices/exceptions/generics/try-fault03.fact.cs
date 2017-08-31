using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _generics_try_fault03_try_fault03_
    {
        [OuterLoop]
        [Fact]
        public void _generics_try_fault03_try_fault03_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\generics\\try-fault03\\try-fault03.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
