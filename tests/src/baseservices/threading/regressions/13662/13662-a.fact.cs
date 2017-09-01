using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _regressions_13662_13662_a_13662_a_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_13662_13662_a_13662_a_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\regressions\\13662\\13662-a\\13662-a.cmd");
        }
    }
}
