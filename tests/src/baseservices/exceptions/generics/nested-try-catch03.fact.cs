using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _generics_nested_try_catch03_nested_try_catch03_
    {
        [OuterLoop]
        [Fact]
        public void _generics_nested_try_catch03_nested_try_catch03_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\generics\\nested-try-catch03\\nested-try-catch03.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
