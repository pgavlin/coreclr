using CoreclrTestLib;
using Xunit;

namespace Regressions_common
{
    class _ThreadCulture_ThreadCulture_
    {
        [OuterLoop]
        [Fact]
        public void _ThreadCulture_ThreadCulture_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\common\\ThreadCulture\\ThreadCulture.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
