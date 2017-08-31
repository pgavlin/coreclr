using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _generics_try_finally03_try_finally03_
    {
        [OuterLoop]
        [Fact]
        public void _generics_try_finally03_try_finally03_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\generics\\try-finally03\\try-finally03.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
