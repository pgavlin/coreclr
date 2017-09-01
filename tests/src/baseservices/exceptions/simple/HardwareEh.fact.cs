using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    public class _simple_HardwareEh_HardwareEh_
    {
        [OuterLoop]
        [Fact]
        public void _simple_HardwareEh_HardwareEh_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\exceptions\\simple\\HardwareEh\\HardwareEh.cmd");
        }
    }
}
