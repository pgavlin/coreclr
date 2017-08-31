using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _unittests_RecursiveThrowNew_RecursiveThrowNew_
    {
        [OuterLoop]
        [Fact]
        public void _unittests_RecursiveThrowNew_RecursiveThrowNew_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\unittests\\RecursiveThrowNew\\RecursiveThrowNew.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
