using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _Boxing_xlang__relsin_cs_il__relsin_cs_il_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _Boxing_xlang__relsin_cs_il__relsin_cs_il_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\xlang\\_relsin_cs_il\\_relsin_cs_il.cmd");
        }
    }
}
