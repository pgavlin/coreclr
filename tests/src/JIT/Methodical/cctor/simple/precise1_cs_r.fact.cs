using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _cctor_simple_precise1_cs_r_precise1_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _cctor_simple_precise1_cs_r_precise1_cs_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\cctor\\simple\\precise1_cs_r\\precise1_cs_r.cmd");
        }
    }
}
