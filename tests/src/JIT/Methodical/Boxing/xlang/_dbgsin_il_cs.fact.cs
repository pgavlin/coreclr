using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _Boxing_xlang__dbgsin_il_cs__dbgsin_il_cs_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _Boxing_xlang__dbgsin_il_cs__dbgsin_il_cs_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\xlang\\_dbgsin_il_cs\\_dbgsin_il_cs.cmd");
        }
    }
}
