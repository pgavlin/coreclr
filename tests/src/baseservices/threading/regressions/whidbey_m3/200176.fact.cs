using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _regressions_whidbey_m3_200176_200176_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_whidbey_m3_200176_200176_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\regressions\\whidbey_m3\\200176\\200176.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
