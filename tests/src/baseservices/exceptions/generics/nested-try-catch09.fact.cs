using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _generics_nested_try_catch09_nested_try_catch09_
    {
        [OuterLoop]
        [Fact]
        public void _generics_nested_try_catch09_nested_try_catch09_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\generics\\nested-try-catch09\\nested-try-catch09.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
