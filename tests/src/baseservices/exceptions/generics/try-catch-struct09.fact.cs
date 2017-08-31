using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _generics_try_catch_struct09_try_catch_struct09_
    {
        [OuterLoop]
        [Fact]
        public void _generics_try_catch_struct09_try_catch_struct09_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\generics\\try-catch-struct09\\try-catch-struct09.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
