using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _nullabletypes_invocation_do_invocation_do_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_invocation_do_invocation_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\invocation_do\\invocation_do.cmd");
        }
    }
}
