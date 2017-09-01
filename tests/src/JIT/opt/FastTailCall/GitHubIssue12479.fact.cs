using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _FastTailCall_GitHubIssue12479_GitHubIssue12479_
    {
        [Fact]
        public void _FastTailCall_GitHubIssue12479_GitHubIssue12479_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\FastTailCall\\GitHubIssue12479\\GitHubIssue12479.cmd");
        }
    }
}
