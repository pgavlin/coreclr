using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _generics_nested_try_catch10_nested_try_catch10_
    {
        [OuterLoop]
        [Fact]
        public void _generics_nested_try_catch10_nested_try_catch10_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\generics\\nested-try-catch10\\nested-try-catch10.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
