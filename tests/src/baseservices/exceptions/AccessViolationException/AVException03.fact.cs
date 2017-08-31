using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _AccessViolationException_AVException03_AVException03_
    {
        [OuterLoop]
        [Fact]
        public void _AccessViolationException_AVException03_AVException03_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\AccessViolationException\\AVException03\\AVException03.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
