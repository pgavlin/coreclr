using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _generics_try_catch_struct01_try_catch_struct01_
    {
        [OuterLoop]
        [Fact]
        public void _generics_try_catch_struct01_try_catch_struct01_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\generics\\try-catch-struct01\\try-catch-struct01.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
