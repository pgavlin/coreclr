using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _generics_nested_try_catch06_nested_try_catch06_
    {
        [OuterLoop]
        [Fact]
        public void _generics_nested_try_catch06_nested_try_catch06_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\generics\\nested-try-catch06\\nested-try-catch06.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
