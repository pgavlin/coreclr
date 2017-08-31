using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _generics_try_catch_finally02_try_catch_finally02_
    {
        [OuterLoop]
        [Fact]
        public void _generics_try_catch_finally02_try_catch_finally02_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\generics\\try-catch-finally02\\try-catch-finally02.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
