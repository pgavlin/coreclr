using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Base_tailcall_tailcall_
    {
        [Fact]
        public void _Old_Base_tailcall_tailcall_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\tailcall\\tailcall.cmd");
        }
    }
}
