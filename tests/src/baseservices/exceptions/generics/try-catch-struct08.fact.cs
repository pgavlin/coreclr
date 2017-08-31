using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _generics_try_catch_struct08_try_catch_struct08_
    {
        [OuterLoop]
        [Fact]
        public void _generics_try_catch_struct08_try_catch_struct08_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\generics\\try-catch-struct08\\try-catch-struct08.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
