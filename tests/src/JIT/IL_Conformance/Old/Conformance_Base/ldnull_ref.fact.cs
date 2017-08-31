using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    class _Old_Conformance_Base_ldnull_ref_ldnull_ref_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_ldnull_ref_ldnull_ref_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ldnull_ref\\ldnull_ref.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
