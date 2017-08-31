using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _generics_try_finally01_try_finally01_
    {
        [OuterLoop]
        [Fact]
        public void _generics_try_finally01_try_finally01_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\generics\\try-finally01\\try-finally01.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
