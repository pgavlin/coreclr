using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _Boxing_xlang__relsin_il_il__relsin_il_il_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _Boxing_xlang__relsin_il_il__relsin_il_il_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\xlang\\_relsin_il_il\\_relsin_il_il.cmd");
        }
    }
}
