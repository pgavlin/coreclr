using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _regressions_30032_30032_30032_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_30032_30032_30032_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\regressions\\30032\\30032\\30032.cmd");
        }
    }
}
