using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    public class _unittests_InnerFinally_InnerFinally_
    {
        [OuterLoop]
        [Fact]
        public void _unittests_InnerFinally_InnerFinally_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\exceptions\\unittests\\InnerFinally\\InnerFinally.cmd");
        }
    }
}
