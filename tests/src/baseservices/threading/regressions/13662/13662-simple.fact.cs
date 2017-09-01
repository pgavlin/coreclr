using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _regressions_13662_13662_simple_13662_simple_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_13662_13662_simple_13662_simple_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\regressions\\13662\\13662-simple\\13662-simple.cmd");
        }
    }
}
