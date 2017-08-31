using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _FastTailCall_GitHubIssue12479_GitHubIssue12479_
    {
        [Fact]
        public void _FastTailCall_GitHubIssue12479_GitHubIssue12479_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\FastTailCall\\GitHubIssue12479\\GitHubIssue12479.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
