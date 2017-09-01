using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Base_ldloc_stloc_ldloc_stloc_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Base_ldloc_stloc_ldloc_stloc_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\ldloc_stloc\\ldloc_stloc.cmd");
        }
    }
}
