using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Base_ldloca_ldloca_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Base_ldloca_ldloca_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\ldloca\\ldloca.cmd");
        }
    }
}
