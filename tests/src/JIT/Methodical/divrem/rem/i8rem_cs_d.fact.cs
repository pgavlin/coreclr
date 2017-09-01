using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _divrem_rem_i8rem_cs_d_i8rem_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_rem_i8rem_cs_d_i8rem_cs_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\rem\\i8rem_cs_d\\i8rem_cs_d.cmd");
        }
    }
}
