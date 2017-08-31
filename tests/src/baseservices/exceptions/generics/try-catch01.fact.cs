using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _generics_try_catch01_try_catch01_
    {
        [OuterLoop]
        [Fact]
        public void _generics_try_catch01_try_catch01_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\generics\\try-catch01\\try-catch01.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
