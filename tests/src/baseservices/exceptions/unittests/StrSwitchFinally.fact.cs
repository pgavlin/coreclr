using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _unittests_StrSwitchFinally_StrSwitchFinally_
    {
        [OuterLoop]
        [Fact]
        public void _unittests_StrSwitchFinally_StrSwitchFinally_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\unittests\\StrSwitchFinally\\StrSwitchFinally.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
