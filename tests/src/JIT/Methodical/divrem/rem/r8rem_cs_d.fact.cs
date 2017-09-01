using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _divrem_rem_r8rem_cs_d_r8rem_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_rem_r8rem_cs_d_r8rem_cs_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\rem\\r8rem_cs_d\\r8rem_cs_d.cmd");
        }
    }
}
