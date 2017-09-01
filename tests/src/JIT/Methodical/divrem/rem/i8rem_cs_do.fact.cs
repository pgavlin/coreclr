using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _divrem_rem_i8rem_cs_do_i8rem_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_rem_i8rem_cs_do_i8rem_cs_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\rem\\i8rem_cs_do\\i8rem_cs_do.cmd");
        }
    }
}
