using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _nullabletypes_invocation_r_invocation_r_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_invocation_r_invocation_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\invocation_r\\invocation_r.cmd");
        }
    }
}
