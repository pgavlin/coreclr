using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _generics_try_catch08_try_catch08_
    {
        [OuterLoop]
        [Fact]
        public void _generics_try_catch08_try_catch08_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\generics\\try-catch08\\try-catch08.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
