using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    class _Old_Conformance_Base_bge_un_r4_bge_un_r4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_bge_un_r4_bge_un_r4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\bge_un_r4\\bge_un_r4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
