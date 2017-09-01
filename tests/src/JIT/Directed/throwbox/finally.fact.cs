using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _throwbox_finally_finally_
    {
        [Fact]
        public void _throwbox_finally_finally_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\throwbox\\finally\\finally.cmd");
        }
    }
}
