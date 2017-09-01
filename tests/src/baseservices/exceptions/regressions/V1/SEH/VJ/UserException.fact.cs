using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    public class _regressions_V1_SEH_VJ_UserException_UserException_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_V1_SEH_VJ_UserException_UserException_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\exceptions\\regressions\\V1\\SEH\\VJ\\UserException\\UserException.cmd");
        }
    }
}
