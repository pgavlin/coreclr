using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _divrem_rem_i4rem_cs_d_i4rem_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_rem_i4rem_cs_d_i4rem_cs_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\rem\\i4rem_cs_d\\i4rem_cs_d.cmd");
        }
    }
}
