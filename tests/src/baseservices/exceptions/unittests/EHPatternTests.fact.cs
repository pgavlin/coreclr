using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _unittests_EHPatternTests_EHPatternTests_
    {
        [OuterLoop]
        [Fact]
        public void _unittests_EHPatternTests_EHPatternTests_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\unittests\\EHPatternTests\\EHPatternTests.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
