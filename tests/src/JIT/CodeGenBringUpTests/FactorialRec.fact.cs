using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _FactorialRec_FactorialRec_
    {
        [OuterLoop]
        [Fact]
        public void _FactorialRec_FactorialRec_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\FactorialRec\\FactorialRec.cmd");
        }
    }
}
