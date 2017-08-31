using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _regressions_13662_13662_simple_13662_simple_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_13662_13662_simple_13662_simple_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\regressions\\13662\\13662-simple\\13662-simple.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
