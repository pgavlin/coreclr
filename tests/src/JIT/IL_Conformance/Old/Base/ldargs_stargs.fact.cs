using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    class _Old_Base_ldargs_stargs_ldargs_stargs_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Base_ldargs_stargs_ldargs_stargs_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\ldargs_stargs\\ldargs_stargs.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
