using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _regressions_beta2_437017_437017_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_beta2_437017_437017_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\regressions\\beta2\\437017\\437017.cmd");
        }
    }
}
