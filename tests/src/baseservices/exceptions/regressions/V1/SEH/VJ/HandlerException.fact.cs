using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    public class _regressions_V1_SEH_VJ_HandlerException_HandlerException_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_V1_SEH_VJ_HandlerException_HandlerException_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\exceptions\\regressions\\V1\\SEH\\VJ\\HandlerException\\HandlerException.cmd");
        }
    }
}
