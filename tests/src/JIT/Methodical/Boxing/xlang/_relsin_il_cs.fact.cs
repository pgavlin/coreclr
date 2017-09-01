using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _Boxing_xlang__relsin_il_cs__relsin_il_cs_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _Boxing_xlang__relsin_il_cs__relsin_il_cs_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\xlang\\_relsin_il_cs\\_relsin_il_cs.cmd");
        }
    }
}
