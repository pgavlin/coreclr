using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _CnsBool_CnsBool_
    {
        [OuterLoop]
        [Fact]
        public void _CnsBool_CnsBool_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\CnsBool\\CnsBool.cmd");
        }
    }
}
