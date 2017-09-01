using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    public class _regressions_V1_SEH_VJ_ExternalException_ExternalException_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_V1_SEH_VJ_ExternalException_ExternalException_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\exceptions\\regressions\\V1\\SEH\\VJ\\ExternalException\\ExternalException.cmd");
        }
    }
}
