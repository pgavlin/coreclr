using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _regressions_whidbeyM3_2_151232_151232_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_whidbeyM3_2_151232_151232_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\regressions\\whidbeyM3.2\\151232\\151232.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
