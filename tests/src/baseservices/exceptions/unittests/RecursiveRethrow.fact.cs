using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _unittests_RecursiveRethrow_RecursiveRethrow_
    {
        [OuterLoop]
        [Fact]
        public void _unittests_RecursiveRethrow_RecursiveRethrow_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\unittests\\RecursiveRethrow\\RecursiveRethrow.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
