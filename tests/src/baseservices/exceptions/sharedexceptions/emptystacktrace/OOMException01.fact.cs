using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _sharedexceptions_emptystacktrace_OOMException01_OOMException01_
    {
        [OuterLoop]
        [Fact]
        public void _sharedexceptions_emptystacktrace_OOMException01_OOMException01_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\sharedexceptions\\emptystacktrace\\OOMException01\\OOMException01.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
