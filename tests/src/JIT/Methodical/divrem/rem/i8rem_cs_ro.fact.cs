using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _divrem_rem_i8rem_cs_ro_i8rem_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_rem_i8rem_cs_ro_i8rem_cs_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\rem\\i8rem_cs_ro\\i8rem_cs_ro.cmd");
        }
    }
}
