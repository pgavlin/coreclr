using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _unittests_ThrowInFinally_ThrowInFinally_
    {
        [OuterLoop]
        [Fact]
        public void _unittests_ThrowInFinally_ThrowInFinally_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\unittests\\ThrowInFinally\\ThrowInFinally.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
