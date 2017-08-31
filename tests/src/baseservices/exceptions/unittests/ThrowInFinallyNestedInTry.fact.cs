using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _unittests_ThrowInFinallyNestedInTry_ThrowInFinallyNestedInTry_
    {
        [OuterLoop]
        [Fact]
        public void _unittests_ThrowInFinallyNestedInTry_ThrowInFinallyNestedInTry_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\unittests\\ThrowInFinallyNestedInTry\\ThrowInFinallyNestedInTry.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
