using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    public class _0202_ThreadCulture_ThreadCulture_
    {
        [OuterLoop]
        [Fact]
        public void _0202_ThreadCulture_ThreadCulture_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Regressions\\coreclr\\0202\\ThreadCulture\\ThreadCulture.cmd");
        }
    }
}
