using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _generics_try_catch_struct05_try_catch_struct05_
    {
        [OuterLoop]
        [Fact]
        public void _generics_try_catch_struct05_try_catch_struct05_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\generics\\try-catch-struct05\\try-catch-struct05.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
