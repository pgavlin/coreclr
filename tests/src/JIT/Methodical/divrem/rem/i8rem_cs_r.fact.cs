using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _divrem_rem_i8rem_cs_r_i8rem_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_rem_i8rem_cs_r_i8rem_cs_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\rem\\i8rem_cs_r\\i8rem_cs_r.cmd");
        }
    }
}
