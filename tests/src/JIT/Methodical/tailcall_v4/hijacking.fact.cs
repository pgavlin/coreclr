using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _tailcall_v4_hijacking_hijacking_
    {
        [ActiveIssue("6217")]//, TestArchitectures.Arm)]
        [Fact]
        public void _tailcall_v4_hijacking_hijacking_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\tailcall_v4\\hijacking\\hijacking.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
