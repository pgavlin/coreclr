using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _unittests_InnerFinally_InnerFinally_
    {
        [OuterLoop]
        [Fact]
        public void _unittests_InnerFinally_InnerFinally_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\unittests\\InnerFinally\\InnerFinally.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
