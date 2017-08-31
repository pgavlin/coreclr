using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _regressions_13662_13662_b_13662_b_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_13662_13662_b_13662_b_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\regressions\\13662\\13662-b\\13662-b.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
