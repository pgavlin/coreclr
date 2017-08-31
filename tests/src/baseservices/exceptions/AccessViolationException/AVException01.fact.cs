using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _AccessViolationException_AVException01_AVException01_
    {
        [OuterLoop]
        [Fact]
        public void _AccessViolationException_AVException01_AVException01_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\AccessViolationException\\AVException01\\AVException01.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
