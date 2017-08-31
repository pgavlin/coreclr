using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _AccessViolationException_AVException02_AVException02_
    {
        [OuterLoop]
        [Fact]
        public void _AccessViolationException_AVException02_AVException02_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\AccessViolationException\\AVException02\\AVException02.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
