using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _hfa_main_testA_hfa_sf1A_d_hfa_sf1A_d_
    {
        [OuterLoop]
        [Fact]
        public void _hfa_main_testA_hfa_sf1A_d_hfa_sf1A_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\hfa\\main\\testA\\hfa_sf1A_d\\hfa_sf1A_d.cmd");
        }
    }
}
