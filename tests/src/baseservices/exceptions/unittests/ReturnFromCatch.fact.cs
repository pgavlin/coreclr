using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _unittests_ReturnFromCatch_ReturnFromCatch_
    {
        [OuterLoop]
        [Fact]
        public void _unittests_ReturnFromCatch_ReturnFromCatch_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\unittests\\ReturnFromCatch\\ReturnFromCatch.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
