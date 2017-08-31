using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _generics_try_catch_finally_struct01_try_catch_finally_struct01_
    {
        [OuterLoop]
        [Fact]
        public void _generics_try_catch_finally_struct01_try_catch_finally_struct01_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\generics\\try-catch-finally-struct01\\try-catch-finally-struct01.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
