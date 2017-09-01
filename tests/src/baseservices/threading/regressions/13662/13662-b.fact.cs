using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _regressions_13662_13662_b_13662_b_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_13662_13662_b_13662_b_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\regressions\\13662\\13662-b\\13662-b.cmd");
        }
    }
}
