using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _hfa_main_testB_hfa_sf2B_r_hfa_sf2B_r_
    {
        [OuterLoop]
        [Fact]
        public void _hfa_main_testB_hfa_sf2B_r_hfa_sf2B_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\hfa\\main\\testB\\hfa_sf2B_r\\hfa_sf2B_r.cmd");
        }
    }
}
