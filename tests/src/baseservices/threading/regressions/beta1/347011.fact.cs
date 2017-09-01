using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _regressions_beta1_347011_347011_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_beta1_347011_347011_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\regressions\\beta1\\347011\\347011.cmd");
        }
    }
}
