using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _addref_addref_
    {
        [OuterLoop]
        [Fact]
        public void _addref_addref_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\addref\\addref.cmd");
        }
    }
}
