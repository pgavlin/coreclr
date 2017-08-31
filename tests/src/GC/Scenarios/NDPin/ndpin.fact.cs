using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    class _NDPin_ndpin_ndpin_
    {
        [Fact]
        public void _NDPin_ndpin_ndpin_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Scenarios\\NDPin\\ndpin\\ndpin.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
