using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _generics_try_finally_struct02_try_finally_struct02_
    {
        [OuterLoop]
        [Fact]
        public void _generics_try_finally_struct02_try_finally_struct02_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\generics\\try-finally-struct02\\try-finally-struct02.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
