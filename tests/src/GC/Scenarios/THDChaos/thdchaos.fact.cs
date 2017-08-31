using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    class _THDChaos_thdchaos_thdchaos_
    {
        [Fact]
        public void _THDChaos_thdchaos_thdchaos_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Scenarios\\THDChaos\\thdchaos\\thdchaos.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
