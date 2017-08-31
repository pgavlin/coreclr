using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _regressions_6906_6906_6906_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_6906_6906_6906_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\regressions\\6906\\6906\\6906.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
