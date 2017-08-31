using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_disconnected_finallybeforetrybody_r_finallybeforetrybody_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_disconnected_finallybeforetrybody_r_finallybeforetrybody_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\disconnected\\finallybeforetrybody_r\\finallybeforetrybody_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
