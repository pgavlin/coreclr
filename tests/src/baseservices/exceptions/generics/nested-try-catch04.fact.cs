using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _generics_nested_try_catch04_nested_try_catch04_
    {
        [OuterLoop]
        [Fact]
        public void _generics_nested_try_catch04_nested_try_catch04_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\generics\\nested-try-catch04\\nested-try-catch04.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
