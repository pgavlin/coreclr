using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _unittests_ThrowInCatch_ThrowInCatch_
    {
        [OuterLoop]
        [Fact]
        public void _unittests_ThrowInCatch_ThrowInCatch_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\unittests\\ThrowInCatch\\ThrowInCatch.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
