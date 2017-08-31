using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _generics_try_catch09_try_catch09_
    {
        [OuterLoop]
        [Fact]
        public void _generics_try_catch09_try_catch09_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\generics\\try-catch09\\try-catch09.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
