using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _simple_HardwareEh_HardwareEh_
    {
        [OuterLoop]
        [Fact]
        public void _simple_HardwareEh_HardwareEh_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\simple\\HardwareEh\\HardwareEh.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
