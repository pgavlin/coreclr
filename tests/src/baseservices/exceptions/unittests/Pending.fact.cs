using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _unittests_Pending_Pending_
    {
        [OuterLoop]
        [Fact]
        public void _unittests_Pending_Pending_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\unittests\\Pending\\Pending.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
