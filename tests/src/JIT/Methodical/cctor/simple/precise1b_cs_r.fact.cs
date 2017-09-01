using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _cctor_simple_precise1b_cs_r_precise1b_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _cctor_simple_precise1b_cs_r_precise1b_cs_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\cctor\\simple\\precise1b_cs_r\\precise1b_cs_r.cmd");
        }
    }
}
