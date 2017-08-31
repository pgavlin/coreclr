using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _regressions_whidbeybeta2_349379_349379_349379_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_whidbeybeta2_349379_349379_349379_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\regressions\\whidbeybeta2\\349379\\349379\\349379.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
