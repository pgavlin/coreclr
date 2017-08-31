using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _generics_try_finally_struct03_try_finally_struct03_
    {
        [OuterLoop]
        [Fact]
        public void _generics_try_finally_struct03_try_finally_struct03_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\generics\\try-finally-struct03\\try-finally-struct03.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
