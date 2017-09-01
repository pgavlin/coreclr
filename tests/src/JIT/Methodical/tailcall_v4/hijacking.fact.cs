using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _tailcall_v4_hijacking_hijacking_
    {
        [ActiveIssue("6217")]//, TestArchitectures.Arm)]
        [Fact]
        public void _tailcall_v4_hijacking_hijacking_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\tailcall_v4\\hijacking\\hijacking.cmd");
        }
    }
}
