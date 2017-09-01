using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _divref_divref_
    {
        [OuterLoop]
        [Fact]
        public void _divref_divref_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\divref\\divref.cmd");
        }
    }
}
