using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_disconnected_finallybeforetrybody_d_finallybeforetrybody_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_disconnected_finallybeforetrybody_d_finallybeforetrybody_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\disconnected\\finallybeforetrybody_d\\finallybeforetrybody_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
