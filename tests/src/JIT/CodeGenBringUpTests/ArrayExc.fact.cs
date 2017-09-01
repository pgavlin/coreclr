using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _ArrayExc_ArrayExc_
    {
        [Fact]
        public void _ArrayExc_ArrayExc_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\ArrayExc\\ArrayExc.cmd");
        }
    }
}
