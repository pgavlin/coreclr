using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _regressions_576463_576463_576463_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_576463_576463_576463_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\regressions\\576463\\576463\\576463.cmd");
        }
    }
}
