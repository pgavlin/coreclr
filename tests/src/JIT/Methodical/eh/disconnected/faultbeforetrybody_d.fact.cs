using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_disconnected_faultbeforetrybody_d_faultbeforetrybody_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_disconnected_faultbeforetrybody_d_faultbeforetrybody_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\disconnected\\faultbeforetrybody_d\\faultbeforetrybody_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
