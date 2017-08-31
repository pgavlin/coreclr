using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _generics_try_catch_finally03_try_catch_finally03_
    {
        [OuterLoop]
        [Fact]
        public void _generics_try_catch_finally03_try_catch_finally03_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\generics\\try-catch-finally03\\try-catch-finally03.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
