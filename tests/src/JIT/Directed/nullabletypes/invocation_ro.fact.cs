using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _nullabletypes_invocation_ro_invocation_ro_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_invocation_ro_invocation_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\invocation_ro\\invocation_ro.cmd");
        }
    }
}
