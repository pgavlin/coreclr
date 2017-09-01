using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    public class _regressions_V1_SEH_VJ_NormalException_NormalException_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_V1_SEH_VJ_NormalException_NormalException_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\exceptions\\regressions\\V1\\SEH\\VJ\\NormalException\\NormalException.cmd");
        }
    }
}
