using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _unittests_RethrowAndFinally_RethrowAndFinally_
    {
        [OuterLoop]
        [Fact]
        public void _unittests_RethrowAndFinally_RethrowAndFinally_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\unittests\\RethrowAndFinally\\RethrowAndFinally.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
