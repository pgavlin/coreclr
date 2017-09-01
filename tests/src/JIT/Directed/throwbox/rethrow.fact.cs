using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _throwbox_rethrow_rethrow_
    {
        [Fact]
        public void _throwbox_rethrow_rethrow_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\throwbox\\rethrow\\rethrow.cmd");
        }
    }
}
