using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_disconnected_faultbeforetrybody_r_faultbeforetrybody_r_
    {
        [Fact]
        public void _eh_disconnected_faultbeforetrybody_r_faultbeforetrybody_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\disconnected\\faultbeforetrybody_r\\faultbeforetrybody_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
