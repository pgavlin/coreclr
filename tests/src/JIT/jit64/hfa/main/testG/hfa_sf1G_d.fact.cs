using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _hfa_main_testG_hfa_sf1G_d_hfa_sf1G_d_
    {
        [OuterLoop]
        [Fact]
        public void _hfa_main_testG_hfa_sf1G_d_hfa_sf1G_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\hfa\\main\\testG\\hfa_sf1G_d\\hfa_sf1G_d.cmd");
        }
    }
}
