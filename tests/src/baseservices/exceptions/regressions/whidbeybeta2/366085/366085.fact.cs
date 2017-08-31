using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _regressions_whidbeybeta2_366085_366085_366085_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_whidbeybeta2_366085_366085_366085_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\regressions\\whidbeybeta2\\366085\\366085\\366085.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
