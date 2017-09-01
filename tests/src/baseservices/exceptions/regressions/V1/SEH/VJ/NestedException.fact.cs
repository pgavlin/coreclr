using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    public class _regressions_V1_SEH_VJ_NestedException_NestedException_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_V1_SEH_VJ_NestedException_NestedException_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\exceptions\\regressions\\V1\\SEH\\VJ\\NestedException\\NestedException.cmd");
        }
    }
}
