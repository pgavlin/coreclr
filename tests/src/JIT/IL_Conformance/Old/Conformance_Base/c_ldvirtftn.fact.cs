using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_c_ldvirtftn_c_ldvirtftn_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_c_ldvirtftn_c_ldvirtftn_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\c_ldvirtftn\\c_ldvirtftn.cmd");
        }
    }
}
