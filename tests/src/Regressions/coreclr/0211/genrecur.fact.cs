using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    public class _0211_genrecur_genrecur_
    {
        [OuterLoop]
        [Fact]
        public void _0211_genrecur_genrecur_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Regressions\\coreclr\\0211\\genrecur\\genrecur.cmd");
        }
    }
}
