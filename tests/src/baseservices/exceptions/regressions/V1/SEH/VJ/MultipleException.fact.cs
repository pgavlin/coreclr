using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    public class _regressions_V1_SEH_VJ_MultipleException_MultipleException_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_V1_SEH_VJ_MultipleException_MultipleException_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\exceptions\\regressions\\V1\\SEH\\VJ\\MultipleException\\MultipleException.cmd");
        }
    }
}
