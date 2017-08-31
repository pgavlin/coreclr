using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    class _NDPin_ndpinfinal_ndpinfinal_
    {
        [Fact]
        public void _NDPin_ndpinfinal_ndpinfinal_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Scenarios\\NDPin\\ndpinfinal\\ndpinfinal.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
