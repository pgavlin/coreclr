using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _CnsBool_CnsBool_
    {
        [OuterLoop]
        [Fact]
        public void _CnsBool_CnsBool_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\CnsBool\\CnsBool.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
