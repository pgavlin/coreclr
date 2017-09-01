using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _divrem_rem_i4rem_cs_r_i4rem_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_rem_i4rem_cs_r_i4rem_cs_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\rem\\i4rem_cs_r\\i4rem_cs_r.cmd");
        }
    }
}
