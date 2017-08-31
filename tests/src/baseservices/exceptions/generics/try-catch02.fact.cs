using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _generics_try_catch02_try_catch02_
    {
        [OuterLoop]
        [Fact]
        public void _generics_try_catch02_try_catch02_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\generics\\try-catch02\\try-catch02.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
