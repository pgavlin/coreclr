using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _simple_finally_finally_
    {
        [OuterLoop]
        [Fact]
        public void _simple_finally_finally_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\simple\\finally\\finally.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
