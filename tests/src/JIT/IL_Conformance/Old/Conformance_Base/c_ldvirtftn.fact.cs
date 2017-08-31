using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    class _Old_Conformance_Base_c_ldvirtftn_c_ldvirtftn_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_c_ldvirtftn_c_ldvirtftn_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\c_ldvirtftn\\c_ldvirtftn.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
