using CoreclrTestLib;
using Xunit;

namespace Regressions_common
{
    public class _ThreadCulture_ThreadCulture_
    {
        [OuterLoop]
        [Fact]
        public void _ThreadCulture_ThreadCulture_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Regressions\\common\\ThreadCulture\\ThreadCulture.cmd");
        }
    }
}
