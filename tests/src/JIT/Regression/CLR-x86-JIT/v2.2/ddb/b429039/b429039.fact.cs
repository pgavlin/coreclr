using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_JIT_v2_2_ddb_b429039_b429039_b429039_
    {
        [Fact]
        public void _CLR_x86_JIT_v2_2_ddb_b429039_b429039_b429039_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\v2.2\\ddb\\b429039\\b429039\\b429039.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
